﻿using ReactiveUI;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Controls;

namespace WeatherApp.ViewModelBase
{
    public class WeatherInfo
    {
            public class WeatherData
        {
            public class Coord
            {
                public double lon { get; set; }
                public double lat { get; set; }
            }

            public class Weather
            {
                // public int id { get; set; }
                public string main { get; set; }
                public string description { get; set; }
                public string icon { get; set; }
            }

            public class Main
            {
                public double temp { get; set; }
                // public double feels_like { get; set; }
                // public double temp_min { get; set; }
                // public double temp_max { get; set; }
                // public int pressure { get; set; }
                public int humidity { get; set; }
            }

            // public class Wind
            // {
            //     public double speed { get; set; }
            //     public int deg { get; set; }
            // }

            // public class Clouds
            // {
            //     public int all { get; set; }
            // }

            public class Sys
            {
                // public int type { get; set; }
                 public int id { get; set; }
                public string country { get; set; }
                // public long sunrise { get; set; }
                // public long sunset { get; set; }
                public string name { get; set; }
            }

            public class root
            {
                public Coord coord { get; set; }
                public List<Weather> weather { get; set; }
                public Main main { get; set; }
        
                public Sys sys { get; set; }
            }
        }
    }


        // public string GetApiKey()
        // {
        //     var json = File.ReadAllText("config.json");
        //     var jsonObject = JObject.Parse(json);
        //     return jsonObject["https://api.openweathermap.org/data/2.5/weather?lat=44.8404400&lon=-0.5805000&appid=260602f7835ea35af678a029bbba75f2&lang=fr&units=metric"].ToString();
        // }

        // public async Task<WeatherData> GetWeatherForCity(string cityName)
        // {
        //     string apiKey = "YOUR_API_KEY";
        //     string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

        //     using (HttpClient client = new HttpClient())
        //     {
        //         var jsonResponse = await client.GetStringAsync(url);

        //         // Parsez la réponse avec Newtonsoft.Json
        //         var jsonObject = JObject.Parse(jsonResponse);

        //         // Créez un objet WeatherData à partir de la réponse JSON
        //         WeatherData weatherData = new WeatherData
        //         {
        //             CityName = jsonObject["name"].ToString(),
        //             Latitude = jsonObject["coord"]["lat"].Value<double>(),
        //             Longitude = jsonObject["coord"]["lon"].Value<double>(),
        //             Temperature = jsonObject["main"]["temp"].Value<double>(),
        //             Description = jsonObject["weather"][0]["description"].ToString(),
        //             Humidity = jsonObject["main"]["humidity"].Value<double>(),
        //             WeatherIcon = $"http://openweathermap.org/img/w/{jsonObject["weather"][0]["icon"].ToString()}.png"
        //         };

        //         return weatherData;
        //     }
    //     }
    // }
}
