using System.ComponentModel;
using VillainsRP_APP.ViewModels;
using Xamarin.Forms;

namespace VillainsRP_APP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}