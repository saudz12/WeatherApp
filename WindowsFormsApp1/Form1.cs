using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string APIKey;
        WeatherDataParser weatherData;
        HashSet<string> cities;

        string responseBody = "";
        public string ResposeBody { get { return responseBody; } }

        static readonly HttpClient client = new HttpClient();

        async public void RESTRequestAsync(string _location, string _apiKey)
        {
            this.Enabled = false;

            responseBody = "error";

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/timeline/{_location}?unitGroup=metric&key={_apiKey}");

                var response = await client.SendAsync(request);

                response.EnsureSuccessStatusCode();

                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }

            StreamWriter jsonFile = new StreamWriter("../../requested.json");

            jsonFile.Write(ResposeBody);
            jsonFile.Flush();
            jsonFile.Close();

            LoadWeather();
            FillChartWithWeatherData();

            this.Enabled = true;
        }

        void LoadWeather()
        {
            weatherData = new WeatherDataParser("../../requested.json");
        }

        private void FillChartWithWeatherData()
        {
            chartWeather.Series.Clear();
            chartWeather.ChartAreas.Clear();

            ChartArea chartArea = new ChartArea("WeatherChartArea");
            chartWeather.ChartAreas.Add(chartArea);

            chartArea.AxisY.Title = "Temperature (°C)";

            chartArea.AxisY2.Enabled = AxisEnabled.True;
            chartArea.AxisY2.Title = "Time of Day";
            chartArea.AxisY2.LabelStyle.Format = "HH:mm";

            Series maxTempSeries = new Series("Max Temperature")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Red
            };

            Series minTempSeries = new Series("Min Temperature")
            {
                ChartType = SeriesChartType.Column,
                Color = System.Drawing.Color.Blue
            };

            chartWeather.Series.Add(maxTempSeries);
            chartWeather.Series.Add(minTempSeries);

            Series maxTempTimeSeries = new Series("Max Temp Time")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Orange,
                BorderWidth = 2,
                YAxisType = AxisType.Secondary
            };

            Series minTempTimeSeries = new Series("Min Temp Time")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Cyan,
                BorderWidth = 2,
                YAxisType = AxisType.Secondary
            };

            chartWeather.Series.Add(maxTempTimeSeries);
            chartWeather.Series.Add(minTempTimeSeries);

            foreach (var day in weatherData.Days)
            {
                maxTempSeries.Points.AddXY(day.Date, day.MaxTemp);
                minTempSeries.Points.AddXY(day.Date, day.MinTemp);

                TimeSpan maxTime = TimeSpan.Parse(day.MaxTempTime);
                TimeSpan minTime = TimeSpan.Parse(day.MinTempTime);

                maxTempTimeSeries.Points.AddXY(day.Date, maxTime.TotalMinutes);
                minTempTimeSeries.Points.AddXY(day.Date, minTime.TotalMinutes);
            }

            chartWeather.ChartAreas["WeatherChartArea"].AxisX.Title = "Date";
            chartWeather.ChartAreas["WeatherChartArea"].AxisX.Interval = 1;
            chartWeather.ChartAreas["WeatherChartArea"].AxisX.LabelStyle.Angle = -45;

            chartWeather.ChartAreas["WeatherChartArea"].AxisY2.Minimum = 0;
            chartWeather.ChartAreas["WeatherChartArea"].AxisY2.Maximum = 1440; 
            chartWeather.ChartAreas["WeatherChartArea"].AxisY2.Interval = 120; 
            chartWeather.ChartAreas["WeatherChartArea"].AxisY2.LabelStyle.Format = "HH:mm";

            for (int i = 0; i <= 1440; i += 120)
            {
                TimeSpan timeSpan = TimeSpan.FromMinutes(i);
                string label = timeSpan.ToString("hh\\:mm");
                chartWeather.ChartAreas["WeatherChartArea"].AxisY2.CustomLabels.Add(i - 60, i + 60, label);
            }

            chartWeather.ChartAreas["WeatherChartArea"].RecalculateAxesScale();

            this.labelTempToday.Text = weatherData.Today.CurrentTemp.ToString() + " C";
            this.labelCurrentStatus.Text = weatherData.Today.Description.ToString();
            this.labelSunrsieTime.Text = weatherData.Today.Sunrise.ToString();
            this.labelSunsetTime.Text = weatherData.Today.Sunset.ToString();
            this.labelWindSpeed.Text = weatherData.Today.CurrentWindSpeed.ToString() + "KM/h";
            this.labelHumidity.Text = weatherData.Today.CurrentHumidity.ToString();
        }

        public Form1()
        {
            cities = new HashSet<string> { "Brasov", "Bucharest", "Iasi", "Cluj", "Craiova" };
            APIKey = "insert_your_api_key_here"; //add your visual crossing API KEY here ... Could add reading from file to make things easier
            InitializeComponent();
        }

        private void buttonGetForecast_Click(object sender, EventArgs e)
        {
            string location = this.comboBoxCities.Text;

            if (cities.Contains(location))
                this.comboBoxCities.BackColor = Color.LightGreen;
            else
                this.comboBoxCities.BackColor = Color.Crimson;

            RESTRequestAsync(location, APIKey);
        }
    }
}
