﻿using FreshMvvm;
using TelerikThemeChangesTabView.Views;
using Xamarin.Forms;

namespace TelerikThemeChangesTabView.ViewModels
{
    public class LoginViewModel : FreshBasePageModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
