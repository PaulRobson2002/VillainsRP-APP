using System;
using VillainsRP_APP.Services;
using VillainsRP_APP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VillainsRP_APP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
