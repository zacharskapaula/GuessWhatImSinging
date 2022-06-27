using GuessWhat.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GuessWhat.Views
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