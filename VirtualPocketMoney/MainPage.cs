using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VirtualPocketMoney
{
    public class MainPage:ContentPage
    {
        public MainPage()
        {
            this.Padding = new Thickness(20, 20, 20, 20);

            
            StackLayout panel = new StackLayout
            {
                Spacing = 15
            };

            panel.Children.Add(new Label { 
                Text="Welcome To Virtual Pocket Money",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                HorizontalTextAlignment=TextAlignment.Center

            });

            panel.Children.Add(new Image {
               Source = "download.png",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }) ;

            panel.Children.Add(new Entry
            {
                Placeholder = "Enter VPM Number",
                PlaceholderColor = Color.Black
            });

            panel.Children.Add(new Entry
            {
                Placeholder = "Password",
                IsPassword=true,
                PlaceholderColor=Color.Black           
            });

            panel.Children.Add(new Button
            {
                Text = "Login"
            });

            panel.Children.Add(new Button
            {
                Text = "Sign Up"
            });

            this.Content = panel;
        }


    }

    
}
