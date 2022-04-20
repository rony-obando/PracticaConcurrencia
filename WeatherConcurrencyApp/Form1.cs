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
        public OpenWeather openWeather;
        public FrmMain()
        {
            httpOpenWeatherClient = new HttpOpenWeatherClient();
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

                WeatherPanel weatherPanel = new WeatherPanel();
                flpContent.Controls.Add(weatherPanel);
            }
            catch (Exception)
            {
                
            }
           
        }

        public async Task Request()
        {
           openWeather = await httpOpenWeatherClient.GetWeatherByCityNameAsync("Managua");
        }
    }
}
