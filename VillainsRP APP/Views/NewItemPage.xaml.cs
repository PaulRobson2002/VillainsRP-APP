using System;
using System.Collections.Generic;
using System.ComponentModel;
using VillainsRP_APP.Models;
using VillainsRP_APP.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VillainsRP_APP.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}