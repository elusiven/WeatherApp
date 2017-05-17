using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using WeatherApp.Helpers;
using WeatherApp.Models;
using Xamarin.Forms.Maps;

namespace WeatherApp.ViewModels
{
    public class WeatherDetailViewModel : BindableBase, INavigatedAware
    {
        public Weather Weather { get; private set; }

        private string _location;

        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _temperature;

        public string Temperature
        {
            get { return _temperature; }
            set { SetProperty(ref _temperature, value); }
        }

        public WeatherDetailViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("WeatherDetail"))
            {
                Weather = (Weather)parameters["WeatherDetail"];

                var loc = await ConvertAddresToGeo.GetLocation(Weather.Latitude, Weather.Longitude);
                Location = loc;
                Description = Weather.Hourly.Summary;
                Temperature = Weather.Currently.Temperature.ToString();
            }
        }
    }
}
