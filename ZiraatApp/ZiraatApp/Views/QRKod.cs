using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ZiraatApp.Views
{
    class QRKod : ContentPage
    {
        public QRKod()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            StackLayout anastack = new StackLayout();
            anastack.VerticalOptions = LayoutOptions.FillAndExpand;
            anastack.HorizontalOptions = LayoutOptions.FillAndExpand;
            anastack.Orientation = StackOrientation.Vertical;

            StackLayout stackTool = new StackLayout();
            stackTool.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackTool.VerticalOptions = LayoutOptions.Start;
            stackTool.BackgroundColor = Color.FromHex("#d90c14");
            stackTool.Orientation = StackOrientation.Horizontal;
            stackTool.Padding = new Thickness(0, 15, 15, 15);

            StackLayout stackBack = new StackLayout();
            stackBack.BackgroundColor = Color.FromHex("#d90c14");
            stackBack.HorizontalOptions = LayoutOptions.Start;
            stackBack.VerticalOptions = LayoutOptions.Center;
            stackBack.Margin = new Thickness(10, 0, 0, 0);

            Image imageBack = new Image();
            imageBack.Source = "back.png";
            imageBack.WidthRequest = 20;
            imageBack.HeightRequest = 20;


            stackBack.Children.Add(imageBack);

            TapGestureRecognizer tabBack = new TapGestureRecognizer();

            tabBack.Tapped += (sender, e) =>
            {
                //bir önceki sayfaya gitmek için kullanılan Kodlama.
                Navigation.PopAsync();
            };
            stackTool.GestureRecognizers.Add(tabBack);

            StackLayout stackZiraatBank = new StackLayout();
            stackZiraatBank.BackgroundColor = Color.FromHex("#d90c14");
            stackZiraatBank.HorizontalOptions = LayoutOptions.Start;
            stackZiraatBank.VerticalOptions = LayoutOptions.Center;

            Image imageZiraatBank = new Image();
            imageZiraatBank.Source = "ziraatSon.png";

            stackZiraatBank.Children.Add(imageZiraatBank);

            stackTool.Children.Add(stackBack);
            stackTool.Children.Add(stackZiraatBank);
            anastack.Children.Add(stackTool);

            StackLayout stackContent = new StackLayout();
            stackContent.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackContent.BackgroundColor = Color.White;
            stackContent.Orientation = StackOrientation.Vertical;

            StackLayout stackCekme = new StackLayout();
            stackCekme.Orientation = StackOrientation.Horizontal;
            stackCekme.BackgroundColor = Color.White;
            stackCekme.Padding = new Thickness(0, 5, 5, 5);


            Label labelCekme = new Label();
            labelCekme.Text = "QR Kod ile Para Çekme";
            labelCekme.VerticalOptions = LayoutOptions.Center;
            labelCekme.Margin = new Thickness(10, 0, 0, 0);
            labelCekme.HorizontalOptions = LayoutOptions.StartAndExpand;
            stackCekme.Children.Add(labelCekme);

            Image imageCekme = new Image();
            imageCekme.HorizontalOptions = LayoutOptions.End;
            imageCekme.Source = "next.png";
            imageCekme.VerticalOptions = LayoutOptions.Center;
            stackCekme.Children.Add(imageCekme);
            imageCekme.WidthRequest = 20;
            imageCekme.HeightRequest = 20;


            stackContent.Children.Add(stackCekme);

            TapGestureRecognizer paraCekme = new TapGestureRecognizer();

            paraCekme.Tapped += (sender, e) =>
            {
                //bir önceki sayfaya gitmek için kullanılan Kodlama.
                Navigation.PushAsync(new QRParaCekme());
            };
            stackCekme.GestureRecognizers.Add(paraCekme);

            BoxView boxGray = new BoxView();
            boxGray.BackgroundColor = Color.Gray;
            boxGray.HeightRequest = 0.5;
            stackContent.Children.Add(boxGray);

            StackLayout stackYatirma = new StackLayout();
            stackYatirma.Orientation = StackOrientation.Horizontal;
            stackYatirma.BackgroundColor = Color.White;
            stackYatirma.Padding = new Thickness(0, 5, 5, 5);


            Label labelYatirma = new Label();
            labelYatirma.Text = "QR Kod ile Para Yatırma ";
            labelYatirma.Margin = new Thickness(10, 0, 0, 0);
            labelYatirma.VerticalOptions = LayoutOptions.Center;
            labelYatirma.HorizontalOptions = LayoutOptions.StartAndExpand;

            Image imageYatirma = new Image();
            imageYatirma.HorizontalOptions = LayoutOptions.End;
            imageYatirma.VerticalOptions = LayoutOptions.Center;
            imageYatirma.Source = "next.png";
            imageYatirma.HeightRequest = 20;
            imageYatirma.WidthRequest = 20;


            stackYatirma.Children.Add(labelYatirma);
            stackYatirma.Children.Add(imageYatirma);
            stackContent.Children.Add(stackYatirma);

            BoxView boxGray2 = new BoxView();
            boxGray2.BackgroundColor = Color.Gray;
            boxGray2.HeightRequest = 0.5;
            stackContent.Children.Add(boxGray2);

            anastack.Children.Add(stackContent);
            Content = anastack;
        }
    }
}
