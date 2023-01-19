using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FreshMvvm;
using TelerikThemeChangesTabView.ViewModels;
using Telerik.XamarinForms.Common;
using Telerik.XamarinForms.Input;

namespace TelerikThemeChangesTabView.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var model = (AboutViewModel)this.BindingContext;
            await model.CoreMethods.PushPageModel<EditorSamplesViewModel>();
        }

        private void SelectionChanged(object sender, ValueChangedEventArgs<int> e)
        {
            ((AboutViewModel)this.BindingContext).UpdateSegmentValues((RadSegmentedControl)sender, e.NewValue);
        }
    }
}