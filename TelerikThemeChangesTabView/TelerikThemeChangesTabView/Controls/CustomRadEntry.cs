using System;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Input;
using Xamarin.Forms;

namespace CMSMechanicalMobile.Controls
{
    public class CustomRadEntry : RadEntry
    {
        public CustomRadEntry()
        {
            HeightRequest = 40;
            //Style = (Style)Application.Current.Resources["RadEntryCustom];

        }
        public static BindableProperty IsValidProperty = BindableProperty.Create(
                                                 propertyName: "IsValid",
                                                 returnType: typeof(bool),
                                                 declaringType: typeof(CustomRadEntry),
                                                 defaultValue: false,
                                                 defaultBindingMode: BindingMode.TwoWay);

        

        public bool IsValid
        {
            get
            {
                return (bool)GetValue(IsValidProperty);
            }
            set
            {
                SetValue(IsValidProperty, value);
                OnPropertyChanged(nameof(IsValid));
            }
        }

        

    }
}
