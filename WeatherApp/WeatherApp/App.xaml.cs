using Microsoft.Practices.Unity;
using Prism.Navigation;
using Prism.Unity;
using WeatherApp.Services;
using WeatherApp.Views;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("Nav/Index");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>("Nav");
            Container.RegisterTypeForNavigation<MainPage>("Index");
            Container.RegisterTypeForNavigation<WeatherDetail>("Weather");
            Container.RegisterType<IApiService, ApiService>();
            
        }
    }
}
