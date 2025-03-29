using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
public class WeatherDay
{
    public string Date { get; set; }
    public double MaxTemp { get; set; }
    public string MaxTempTime { get; set; }
    public double MinTemp { get; set; }
    public string MinTempTime { get; set; }
}

public class CurrentDay
{
    public double CurrentTemp { get; set; }
    public string Description { get; set; }
    public string Conditions { get; set; }
    public string Sunrise { get; set; }
    public string Sunset { get; set; }
    public double CurrentWindSpeed { get; set; }
    public double CurrentHumidity { get; set; }
}

public class WeatherDataParser
{
    public List<WeatherDay> Days { get; private set; }
    public CurrentDay Today { get; private set; }

    public WeatherDataParser(string filePath)
    {
        Days = new List<WeatherDay>();
        try
        {
            string jsonContent = File.ReadAllText(filePath);
            ParseWeatherData(jsonContent);
        }
        catch (FileNotFoundException)
        {
            throw new FileNotFoundException($"Weather data file not found at: {filePath}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Error reading weather data: {ex.Message}");
        }
    }

    private void ParseWeatherData(string jsonData)
    {
        var hours = new List<JToken> { };
        var weatherData = JObject.Parse(jsonData);
        var days = weatherData["days"].Take(7);

        ///*

        foreach (var day in days)
        {
            hours = day["hours"].ToList();

            var maxTempHour = hours.OrderByDescending(h => h["feelslike"].Value<double>()).First();

            var minTempHour = hours.OrderBy(h => h["feelslike"].Value<double>()).First();

            var weatherDay = new WeatherDay
            {
                Date = day["datetime"].ToString(),
                MaxTemp = day["tempmax"].Value<double>(),
                MaxTempTime = maxTempHour["datetime"].ToString(),
                MinTemp = day["tempmin"].Value<double>(),
                MinTempTime = minTempHour["datetime"].ToString()
            };
            Days.Add(weatherDay);
        }

        var currentDay = days.First(); 
        var currentHour = DateTime.Now.Hour;

        hours = currentDay["hours"].ToList();
        var closestHour = hours.OrderBy(h => Math.Abs(currentHour - int.Parse(h["datetime"].ToString().Split(':')[0]))).First();
        
         //*/
        /*
         
        foreach (var day in days)
        {
            hours = day["hours"].ToList();
            double maxFeelsLike = double.MinValue;
            double minFeelsLike = double.MaxValue;
            string maxFeelsLikeTime = "";
            string minFeelsLikeTime = "";

            foreach (var hour in hours)
            {
                double feelsLike = hour["feelslike"].Value<double>();
                if (feelsLike > maxFeelsLike)
                {
                    maxFeelsLike = feelsLike;
                    maxFeelsLikeTime = hour["datetime"].ToString();
                }
                if (feelsLike < minFeelsLike)
                {
                    minFeelsLike = feelsLike;
                    minFeelsLikeTime = hour["datetime"].ToString();
                }
            }

            var weatherDay = new WeatherDay
            {
                Date = day["datetime"].ToString(),
                MaxTemp = maxFeelsLike,
                MaxTempTime = maxFeelsLikeTime,
                MinTemp = minFeelsLike,
                MinTempTime = minFeelsLikeTime
            };
            Days.Add(weatherDay);
        }

        var currentDay = days.First(); // First day is today
        var currentHour = DateTime.Now.Hour;

        hours = currentDay["hours"].ToList();
        var closestHour = hours
            .OrderBy(h => Math.Abs(currentHour -
                         int.Parse(h["datetime"].ToString().Split(':')[0])))
            .First();

        */

        Today = new CurrentDay
        {
            //CurrentTemp = closestHour["temp"].Value<double>(),
            CurrentTemp = closestHour["feelslike"].Value<double>(),
            Description = currentDay["description"].ToString(),
            Conditions = currentDay["conditions"].ToString(),
            Sunrise = currentDay["sunrise"].ToString(),
            Sunset = currentDay["sunset"].ToString(),
            CurrentWindSpeed = closestHour["windspeed"].Value<double>(),
            CurrentHumidity = closestHour["humidity"].Value<double>()
        };
    }
}