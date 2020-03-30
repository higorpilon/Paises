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


        public Form1()
        {
            InitializeComponent();
           
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
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
           
            if (paises.Count == 0)
            {
                MessageBox.Show("Atenção!", "Não ha ligação a internet.",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            


            lbPaises.DataSource = paises;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/Flag_of_Brazil.svg/1200px-Flag_of_Brazil.svg.png");

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
            MessageBox.Show("NNão está implementado ainda");
        }

        private async Task LoadApiCountries()
        {
            progressBarPaises.Value = 0;

            var response = await apiService.GetCountries("http://restcountries.eu", "/rest/v2/all");

            paises = (List<Pais>)response.Result;
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCapital.Text = $"Capital: {paises[lbPaises.SelectedIndex].capital}";
            lblNome.Text = $"Nome: {paises[lbPaises.SelectedIndex].name}";
            lblGini.Text = $"Nome: {paises[lbPaises.SelectedIndex].currencies[0].name}";

            // SvgTransformConverter svg = new SvgTransformConverter();



        }



    }
}
