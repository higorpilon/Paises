using Newtonsoft.Json;
using Paises.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;
using System.Net;
using System.Drawing.Imaging;
using System.IO;
using Svg.Transforms;
using Svg.ExtensionMethods;
using Svg.Web;
using Paises.Services;
using System.Reflection;
using GMap.NET.MapProviders;
using Svg;
using System.Windows.Media.Imaging;

namespace Paises
{
    public partial class Form1 : Form
    {


        #region Atributos
        private NetworkService networkService;
        private ApiService apiService;
        private List<Pais> paises = new List<Pais>();
        private DialogService dialogService;
        private BitmapImage flag;

        #endregion
        public DataService dataService { get; set; }

        public Form1()
        {
            InitializeComponent();

            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            flag = new BitmapImage();
            LoadPaises();


        }

        private async void LoadPaises()
        {
            bool load;

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                LoadLocalCountries();
                load = false;

            }
            else
            {
                await LoadApiCountries();
                load = true;

            }

            // if (paises.Count == 0)
            // {
            //      MessageBox.Show("Atenção!", "Não ha ligação a internet.",MessageBoxButtons.OK,MessageBoxIcon.Information);
            // return;
            // }



            lbPaises.DataSource = paises;



            progressBarPaises.Value = 100;
            if (load)
            {
                lblStatus.Text = $"Países carregados com sucesso no dia {DateTime.Now.ToShortTimeString()}";
            }
            else
            {
                lblStatus.Text = $"Países carregados com sucesso no dia {DateTime.Now.ToShortTimeString()} da Base de Dados";
            }


        }

        private void LoadLocalCountries()
        {
            paises = dataService.GetDataCountries();
        }

        private async Task LoadApiCountries()
        {
            progressBarPaises.Value = 0;

            var response = await apiService.GetCountries("http://restcountries.eu", "/rest/v2/all");

            paises = (List<Pais>)response.Result;

            await dataService.SaveData(paises);
            await DownloadFlags();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pais country = (Pais)lbPaises.SelectedItem;

            lblCapital.Text = $"Capital: {country.capital}";
            lblNome.Text = $"Nome: {country.name}";
            lblGini.Text = $"Gini: {country.gini}";
            lblRegiao.Text = $"Region: {country.region}";
            lblSubRegiao.Text = $"SubRegion: {country.subregion}";
            if (country.latlng.Count > 0)
            {
                lblLat.Text = $"Lat: {country.latlng[0]} / Lng: {country.latlng[1]}";
            }
            else
            {
                lblLat.Text = $"Lat: ";
            }

            lblNative.Text = $"Native Name: {country.nativeName}";
            lblCioc.Text = $"Cioc: {country.cioc}";
            lblDemonym.Text = $"Demonym: {country.demonym}";
            lblNumeric.Text = $"Numeric: {country.numericCode}";
            lblArea.Text = $"Area: {country.area}";
            lblPopulacao.Text = $"População: {country.population}";

            lbCurrencies.DataSource = country.currencies.ToList();
            lbLanguages.DataSource = country.languages.ToList();

            // $"@C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\onlineflags\{country.alpha3Code}.jpg";
            try
            {
                pictureBox1.Load($@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\onlineflags\{country.alpha3Code}.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Impossível carregar a bandeira do país");

            }

            // lbl

            //translations
            lblBr.Text = $"BR: {country.translations.br}";
            lblPt.Text = $"PT: {country.translations.pt}";
            lblDe.Text = $"DE: {country.translations.de}";
            lblIt.Text = $"IT: {country.translations.it}";
            lblEs.Text = $"ES: {country.translations.es}";
            lblFa.Text = $"FA: {country.translations.fa}";
            lblNl.Text = $"NL: {country.translations.nl}";
            lblFr.Text = $"FR: {country.translations.fr}";
            lblJa.Text = $"JA: {country.translations.ja}";
            lblHr.Text = $"HR: {country.translations.hr}";


            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            if (country.latlng.Count > 0)
            {
                map.Position = new GMap.NET.PointLatLng(country.latlng[0], country.latlng[1]);
            }

            map.Zoom = 15;


            lbBorders.DataSource = (List<object>)country.borders.ToList();
            lbBorders.SelectedItem = null;


            


        }


        private void lbCurrencies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async Task DownloadFlags()
        {
            await Task.Run(() =>
            {

                //fazer download das bandeiras

                using (WebClient client = new WebClient())
                {

                    foreach (var country in paises)
                    {

                        // country.flag, $@"flagsapi\{country.alpha3Code}.svg"

                        try
                        {


                            if (!File.Exists($@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\onlineflags\{country.alpha3Code}.jpg"))
                            {

                                client.DownloadFile(country.flag, $@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\flagsapi\{country.alpha3Code}.svg");

                                ConvertSvgToJpgCountries(country.alpha3Code);
                            }
                        }

                        catch (Exception ex)
                        {


                            MessageBox.Show(ex.Message, "Erro ao mostrar das imagens");
                        }
                    }
                }
            });
        }


        private void SetFlagImage(Pais currentCountry)
        {

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + $@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\onlineflags\{currentCountry.alpha3Code}.jpg", UriKind.Absolute); //consertar aqui
            bitmap.EndInit();
            flag = bitmap;
            //Flag.Source = bitmap;

        }


        private void ConvertSvgToJpgCountries(string alpha3Code)
        {
            try
            {
                string flagSvg = $@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\flagsapi\{alpha3Code}.svg";

                var svg = SvgDocument.Open(flagSvg);

                Bitmap map = svg.Draw(400, 230);

                string flagJpg = $@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\onlineflags\{alpha3Code}.jpg";

                map.Save(flagJpg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void lbBorders_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbBorders.SelectedItem  != null)
            {
                string ct = lbBorders.SelectedItem.ToString();
                Pais country = new Pais();

                List<Pais> lista = (List<Pais>)paises.Where(x => x.alpha3Code == ct).ToList();


                country = lista[0];

                lblCapital.Text = $"Capital: {country.capital}";
                lblNome.Text = $"Nome: {country.name}";
                lblGini.Text = $"Gini: {country.gini}";
                lblRegiao.Text = $"Region: {country.region}";
                lblSubRegiao.Text = $"SubRegion: {country.subregion}";
                if (country.latlng.Count > 0)
                {
                    lblLat.Text = $"Lat: {country.latlng[0]} / Lng: {country.latlng[1]}";
                }
                else
                {
                    lblLat.Text = $"Lat: ";
                }

                lblNative.Text = $"Native Name: {country.nativeName}";
                lblCioc.Text = $"Cioc: {country.cioc}";
                lblDemonym.Text = $"Demonym: {country.demonym}";
                lblNumeric.Text = $"Numeric: {country.numericCode}";
                lblArea.Text = $"Area: {country.area}";
                lblPopulacao.Text = $"População: {country.population}";

                //LIstboxs
                lbCurrencies.DataSource = country.currencies.ToList();
                lbLanguages.DataSource = country.languages.ToList();


                try
                {
                    pictureBox1.Load($@"C:\Users\Higor\source\repos\higorpilon\Paises\Paises\Paises\onlineflags\{country.alpha3Code}.jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Impossível carregar a bandeira do país");

                }

                // lbl

                //translations
                lblBr.Text = $"BR: {country.translations.br}";
                lblPt.Text = $"PT: {country.translations.pt}";
                lblDe.Text = $"DE: {country.translations.de}";
                lblIt.Text = $"IT: {country.translations.it}";
                lblEs.Text = $"ES: {country.translations.es}";
                lblFa.Text = $"FA: {country.translations.fa}";
                lblNl.Text = $"NL: {country.translations.nl}";
                lblFr.Text = $"FR: {country.translations.fr}";
                lblJa.Text = $"JA: {country.translations.ja}";
                lblHr.Text = $"HR: {country.translations.hr}";

                map.DragButton = MouseButtons.Left;
                map.MapProvider = GMapProviders.GoogleMap;
                if (country.latlng.Count > 0)
                {
                    map.Position = new GMap.NET.PointLatLng(country.latlng[0], country.latlng[1]);
                }

                map.Zoom = 15;
            }
            
            
        }
    }
}
