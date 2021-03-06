using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;

namespace VillainsRP_APP.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        async void GoToDiscord(object sender, EventArgs args)
        {
            try
            {
                await Browser.OpenAsync("https://discord.gg/5u7apyVAnk", BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
    }
}