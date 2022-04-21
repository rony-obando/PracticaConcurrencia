using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrencyApp.Infrastructure.OpenWeatherClient;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class FrmMain : Form
    {
        public HttpOpenWeatherClient httpOpenWeatherClient;
        public List<OpenWeather> openWeather;
        //public List<Task<OpenWeather>> opens;
        public List<string> citys;
        public FrmMain()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
            citys.Add("Managua");
            citys.Add("Madrid");
            citys.Add("new york");
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(Request).Wait();
                if(openWeather == null)
                {
                    throw new NullReferenceException("Fallo al obtener el objeto OpeWeather.");
                }

                WeatherPanel weatherPanel = new WeatherPanel(openWeather);
                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception)
            {
                
            }
           
        }

        public async Task Request()
        {
            foreach (string a in citys)
            {
                openWeather.Add(await httpOpenWeatherClient.GetWeatherByCityNameAsync(a));
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
