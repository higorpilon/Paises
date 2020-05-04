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
using Svg;
using Svg.ExtensionMethods;
using Svg.Web;
using Paises.Services;

namespace Paises
{
    public partial class Form1 : Form
    {


        #region Atributos
        private NetworkService networkService;
        private ApiService apiService;
        private List<Pais> paises = new List<Pais>();
        private DialogService dialogService;
        #endregion
        public DataService dataService { get; set; }

        public Form1()
        {
            InitializeComponent();

            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
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
            lblLat.Text = $"Lat: {country.latlng[0]} / Lng: {country.latlng[1]}";
            lblNative.Text = $"Native Name: {country.nativeName}";
            lblCioc.Text = $"Cioc{country.cioc}";
            lblDemonym.Text = $"Demonym: {country.demonym}";
            lblNumeric.Text = $"Numeric: {country.numericCode}";
            lblArea.Text = $"Area: {country.area}";
            lblPopulacao.Text = $"População: {country.population}";

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
            



            // SvgTransformConverter svg = new SvgTransformConverter();



        }



    }
}
