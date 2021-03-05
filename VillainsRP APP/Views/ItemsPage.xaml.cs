using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VillainsRP_APP.Models;
using VillainsRP_APP.ViewModels;
using VillainsRP_APP.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VillainsRP_APP.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}