using FreshMvvm;
using Sample.Mapper;
using TelerikThemeChangesTabView.ViewModels;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            FreshPageModelResolver.PageModelMapper = new SampleFreshPageModelMapper();
            var tabbedNavigation = new FreshTabbedNavigationContainer();
            tabbedNavigation.AddTab<AboutViewModel>("About", "calendar.png");
            tabbedNavigation.AddTab<LoginViewModel>("Log IN", "calendar.png");
            tabbedNavigation.AddTab<EditorSamplesViewModel>("Editor Sample", "calendar.png");
            App.Current.MainPage = tabbedNavigation;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
