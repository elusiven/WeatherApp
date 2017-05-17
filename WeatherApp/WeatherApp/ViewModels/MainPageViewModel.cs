using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using WeatherApp.Helpers;
using WeatherApp.Services;
using WeatherApp.Views;

namespace WeatherApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private readonly IApiService _apiService;
        private readonly INavigationService _navService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        private string _location;

        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }

        public MainPageViewModel(IApiService apiService, INavigationService navigationService)
        {
            _apiService = apiService;
            _navService = navigationService;
        }

        public ICommand FindPositionCommand { get { return new DelegateCommand(async () =>
        {
            var pos = await ConvertAddresToGeo.GetPosition(Address);
            var response = await _apiService.GetAsync(pos.Latitude, pos.Longitude);
            if (response == null) return;
            var navParameters = new NavigationParameters {{"WeatherDetail", response}};
            await _navService.NavigateAsync("Weather", navParameters);
        });} }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
