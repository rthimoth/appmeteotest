using Avalonia.Controls;
using ReactiveUI;
using Newtonsoft.Json.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using WeatherApp.ViewModelBase;
using Newtonsoft.Json;
using System.Text;

namespace WeatherApp.Views;

public partial class MainWindow : WeatherInfo
{
    public MainWindow()
    {
        InitializeComponent();
    }

    string APIKey = "260602f7835ea35af678a029bbba75f2";
    private void btnSearch_Click(object sender, EventArgs e)
    {
        
    }

    void getWeather()
    {
        using (WebClient web = new WebClient())
        {
            string url = string.Format("https://api.openweathermap.org/data/2.5/weather?lat=44.8404400&lon=-0.5805000&appid={1}&lang=fr&units=metric", TBCity.text , APIKey);
            var json = web.DownloadString(url);
            WheaterInfo.root infos = JsonConvert.DeserializeObject<WheaterInfo.root>(json);
        }

    }
        
}