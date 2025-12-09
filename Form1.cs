using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        string FullName;
        WeatherData weather;
        public Form1()
        {
            InitializeComponent();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            FullName = Properties.Settings.Default.FullName;
            await Task.Run(() => load_data());
            set_data();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Location fRM_Location = new FRM_Location();
            fRM_Location.Show();
        }
        private void load_data()
        {
            var URL = "http://api.weatherstack.com/current?access_key=XXXXXXXXXXXXXXXXXXXXXXX&query=" + FullName;
            HTTPHelper helper = new HTTPHelper();
            var data = helper.GetJsonAsync(URL).GetAwaiter().GetResult();
            weather = Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherData>(data);
        }
        private void set_data()
        {
            Discription_Label.Text = string.Join("",weather.request.query);
            pictureBox1.ImageLocation = string.Join("", weather.current.weather_icons);
            Tempereture_Degree_Label.Text = weather.current.temperature.ToString();
            Wind_Degree_Label.Text = weather.current.wind_speed.ToString();
            Humidity_Degree_Label.Text = weather.current.humidity.ToString();
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
