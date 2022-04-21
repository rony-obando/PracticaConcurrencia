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
    public partial class DetailsWeather : UserControl
    {
        OpenWeather open;
        public DetailsWeather(OpenWeather open)
        {
            this.open=open;
            InitializeComponent();
        }

        private void DetailsWeather_Load(object sender, EventArgs e)
        {
            lblDetailValue.Text = open.Wind.Speed.ToString();
            lblDetail.Text = open.Base;
        }
    }
}
