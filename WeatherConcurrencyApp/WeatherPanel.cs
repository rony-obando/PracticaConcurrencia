using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherConcurrentApp.Domain.Entities;

namespace WeatherConcurrencyApp
{
    public partial class WeatherPanel : UserControl
    { 
        List<OpenWeather> open;
        public WeatherPanel(List<OpenWeather> open)
        {
            this.open = open;
            InitializeComponent();
        }

        private void WeatherPanel_Load(object sender, EventArgs e)
        {
            lblCity.Text = open.Name;
            lblTemperature.Text = open.Weather[0].Description;
            lblWeather.Text = open.Weather[0].Main;
            DetailsWeather details = new DetailsWeather(open);
        }
    }
}
