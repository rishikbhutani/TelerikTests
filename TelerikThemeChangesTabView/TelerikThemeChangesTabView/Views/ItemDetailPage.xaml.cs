using System.ComponentModel;
using TelerikThemeChangesTabView.ViewModels;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView.Views
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