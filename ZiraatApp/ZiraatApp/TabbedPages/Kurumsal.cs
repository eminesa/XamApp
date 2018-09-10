using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ZiraatApp.TabbedPages
{
    class Kurumsal :ContentPage
    {
        public Kurumsal()
        {
            Title = "Kurumsal";
            StackLayout stc = new StackLayout();
            stc.VerticalOptions = LayoutOptions.FillAndExpand;
            stc.HorizontalOptions = LayoutOptions.FillAndExpand;
            stc.Orientation = StackOrientation.Vertical;

            Entry entryMusteriNo = new Entry();
            entryMusteriNo.Placeholder = "Müşteri Numaranız";
            entryMusteriNo.PlaceholderColor = Color.LightGray;
            entryMusteriNo.VerticalOptions = LayoutOptions.Start;
            entryMusteriNo.HorizontalOptions = LayoutOptions.FillAndExpand;
            entryMusteriNo.Margin = new Thickness(20, 20, 20, 0);
            entryMusteriNo.MaxLength = 11;

            Entry entrySifre = new Entry();
            entrySifre.Placeholder = "Şifreniz";
            entrySifre.PlaceholderColor = Color.LightGray;
            entrySifre.MaxLength = 25;
            entrySifre.VerticalOptions = LayoutOptions.Start;
            entrySifre.HorizontalOptions = LayoutOptions.FillAndExpand;
            entrySifre.Margin = new Thickness(20, 20, 20, 0);
            
            Entry entryKullaniciAdi = new Entry();
            entryKullaniciAdi.Placeholder = "Şifre";
            entryKullaniciAdi.PlaceholderColor = Color.LightGray;
            entryKullaniciAdi.MaxLength = 25;
            entryKullaniciAdi.VerticalOptions = LayoutOptions.Start;
            entryKullaniciAdi.HorizontalOptions = LayoutOptions.FillAndExpand;
            entryKullaniciAdi.Margin = new Thickness(20, 20, 20, 0);

            Button buttonDevam = new Button();
            buttonDevam.Text = "Devam";
            buttonDevam.TextColor = Color.White;
            buttonDevam.BackgroundColor = Color.FromHex("#d90c14");
            buttonDevam.Margin = new Thickness(20, 55, 20, 10);
            buttonDevam.VerticalOptions = LayoutOptions.Fill;
            buttonDevam.HorizontalOptions = LayoutOptions.FillAndExpand;

            Label labelUnuttum = new Label();
            labelUnuttum.Text = "Şifremi unuttum";
            labelUnuttum.TextColor = Color.Black;
            labelUnuttum.FontSize = 12;
            labelUnuttum.FontFamily = "sans-serif-light";
            labelUnuttum.HorizontalOptions = LayoutOptions.Center;

            stc.Children.Add(entryMusteriNo);
            stc.Children.Add(entrySifre);
            stc.Children.Add(entryKullaniciAdi);
            stc.Children.Add(buttonDevam);
            stc.Children.Add(labelUnuttum);
            
            Content = stc;
        }
    }
}
