using System;
using System.Collections.Generic;
using System.ComponentModel;
using TelerikThemeChangesTabView.Models;
using TelerikThemeChangesTabView.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikThemeChangesTabView.Views
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