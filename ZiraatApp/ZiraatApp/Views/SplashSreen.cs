using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ZiraatApp.Views
{
    public class SplashSreen : ContentPage
    {
        Image splashImage;
        public SplashSreen()
        {

          NavigationPage.SetHasNavigationBar(this, false);  // action bar'ın görünüp görünmemesi için ayarlama yapar 

            var sub = new AbsoluteLayout();

            //StackLayout layout = new StackLayout();
            //layout.BackgroundColor = Color.FromHex("#d90c14");

            splashImage = new Image
            {
                Source = "headset.png",
                WidthRequest = 250,
                HeightRequest = 55,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions= LayoutOptions.Center

            };
            //Content = layout;

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);

            AbsoluteLayout.SetLayoutBounds(splashImage,
           new Rectangle(0.5, 05, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#d90c14");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await splashImage.ScaleTo(1, 2000);
            await splashImage.ScaleTo(0.9, 1500, Easing.CubicIn);
            await splashImage.ScaleTo(150, 1200, Easing.Linear);

            Application.Current.MainPage = new NavigationPage(new MainPage());
        

        }
    }
}
