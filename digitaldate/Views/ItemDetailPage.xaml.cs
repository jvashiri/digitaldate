using System.ComponentModel;
using Xamarin.Forms;
using digitaldate.ViewModels;

namespace digitaldate.Views
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