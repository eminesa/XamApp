using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ZiraatApp.Views
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            //Ana stackLayout
            StackLayout slc = new StackLayout();
            slc.Orientation = StackOrientation.Vertical;
            slc.VerticalOptions = LayoutOptions.FillAndExpand;
            slc.HorizontalOptions = LayoutOptions.FillAndExpand;

            StackLayout stackTool = new StackLayout();
            stackTool.Orientation = StackOrientation.Horizontal;
            stackTool.BackgroundColor = Color.FromHex("#d90c14");
            stackTool.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackTool.VerticalOptions = LayoutOptions.StartAndExpand;
            stackTool.Padding = new Thickness(10, 10, 10, 10);

           
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (sender, e) =>
            {
                // cast to an image
              //  DisplayAlert("uyarı", "tıklandı", "iptal");
                DisplayAlert("uyarı","istediğiniz numaraya şu anda yönlendiremiyorum. Daha sonra tekar deneyin ","Tamam");

                // now you have a reference to the image
            };
            StackLayout stackHead = new StackLayout();
            stackHead.HorizontalOptions = LayoutOptions.StartAndExpand;
            
            Image imageHead = new Image();
            imageHead.Source = "headset.png";
            imageHead.VerticalOptions = LayoutOptions.Center;

            stackHead.Children.Add(imageHead);
            stackHead.GestureRecognizers.Add(tapGestureRecognizer);
            stackTool.Children.Add(stackHead);

            StackLayout stackName = new StackLayout();
            stackName.HorizontalOptions = LayoutOptions.CenterAndExpand;
          

            Image imageName = new Image();
            imageName.Source = "ziraatSon.png";
            imageName.VerticalOptions = LayoutOptions.Center;
            stackName.Children.Add(imageName);
            
            stackTool.Children.Add(stackName);

            StackLayout stackLang = new StackLayout();
            stackLang.HorizontalOptions = LayoutOptions.EndAndExpand;
           
           
            Label labelLang = new Label();
            labelLang.Text = "EN";
            labelLang.TextColor = Color.White;
            labelLang.FontSize = 14;
            labelLang.VerticalOptions = LayoutOptions.Center;
            stackLang.Children.Add(labelLang);

            stackTool.Children.Add(stackLang);
            slc.Children.Add(stackTool);
           

    //        var imageHeadGrid = new Image()
    //        {
    //            Source = "headset.png",
    //            VerticalOptions = LayoutOptions.Center,
    //            HorizontalOptions = LayoutOptions.FillAndExpand,
    //        };

    //        var imageZiraatNameGrid = new Image()
    //        {
    //            Source = "ziraatSon.png",
    //            WidthRequest = 350,
    //            Margin = new Thickness(45, 0, 0, 0),
    //            HeightRequest = 37,
    //            VerticalOptions = LayoutOptions.Center,
    //            HorizontalOptions = LayoutOptions.CenterAndExpand,
    //        };

    //        var labelLanguage = new Label()
    //        {
    //            VerticalOptions = LayoutOptions.Center,
    //            HorizontalOptions = LayoutOptions.EndAndExpand,
    //            Margin = new Thickness(5, 0, 20, 0),
    //            Text = "EN",
    //            TextColor = Color.White,
    //        };


    //        var gridLayoutTool = new Grid
    //        {
    //            HorizontalOptions = LayoutOptions.FillAndExpand,
    //            HeightRequest = 40,
    //            ColumnDefinitions = new ColumnDefinitionCollection() {
    //    new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) },
    //    new ColumnDefinition() { Width = new GridLength(2, GridUnitType.Star) },
    //    new ColumnDefinition() { Width = new GridLength(3, GridUnitType.Star) },

    //},
    //            RowDefinitions = new RowDefinitionCollection() {
    //    new RowDefinition() { Height = GridLength.Auto }
    //}
    //        };
    //        gridLayoutTool.Padding = new Thickness(10, 10, 10, 10);
    //        gridLayoutTool.BackgroundColor = Color.FromHex("#d90c14");
    //        gridLayoutTool.Children.Add(imageHeadGrid, 0, 0);
    //        gridLayoutTool.Children.Add(imageZiraatNameGrid, 1, 0);
    //        gridLayoutTool.Children.Add(labelLanguage, 2, 0);

    //        slc.Children.Add(gridLayoutTool);



            ///Orta kısım
            StackLayout slcAra = new StackLayout();
            slcAra.BackgroundColor = Color.White;
            slcAra.HeightRequest = 180;
            slcAra.Orientation = StackOrientation.Vertical;


            Image image = new Image();
            image.Margin = new Thickness(0, 20, 0, 0);
            image.Source = "phone.png";
            image.HeightRequest = 60;
            image.WidthRequest = 45;

            Label labelName = new Label();
            labelName.Text = "Mobil Bankacılık";
            labelName.HorizontalOptions = LayoutOptions.Center;
            labelName.TextColor = Color.FromHex("#d90c14");

            Button buttonSignIn = new Button();
            buttonSignIn.Text = "Giriş";
            buttonSignIn.TextColor = Color.FromHex("#d90c14");
            buttonSignIn.BackgroundColor = Color.White;

            slcAra.Children.Add(image);
            slcAra.Children.Add(labelName);
            slcAra.Children.Add(buttonSignIn);

            //Alt kısımdaki stacklar 

            StackLayout stackFoot = new StackLayout();
            stackFoot.Orientation = StackOrientation.Vertical;
            stackFoot.VerticalOptions = LayoutOptions.FillAndExpand;
            stackFoot.BackgroundColor = Color.FromHex("#d90c14");
            stackFoot.HorizontalOptions = LayoutOptions.FillAndExpand;

         
            StackLayout stackEnUst = new StackLayout();
            stackEnUst.BackgroundColor = Color.FromHex("#d90c14");
            stackEnUst.Orientation = StackOrientation.Horizontal;
            stackEnUst.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackEnUst.VerticalOptions = LayoutOptions.FillAndExpand;

            BoxView boxViewBoy = new BoxView();
            boxViewBoy.BackgroundColor = Color.Gray;
            boxViewBoy.HeightRequest = 1;
            stackFoot.Children.Add(boxViewBoy);


            StackLayout stackQrKod = new StackLayout();
            stackQrKod.Orientation = StackOrientation.Vertical;
            stackQrKod.BackgroundColor = Color.FromHex("#d90c14");
            stackQrKod.WidthRequest = 290;
            stackQrKod.VerticalOptions = LayoutOptions.Start;
            stackQrKod.HorizontalOptions = LayoutOptions.StartAndExpand;

            var TapQR = new TapGestureRecognizer();

            TapQR.Tapped += (sender, e) => {

                //NavigationPage nv1 = new NavigationPage(new QRKod());
                //nv1.BarBackgroundColor = Color.Red;
                //nv1.BarTextColor = Color.White;
                // App.Current.MainPage = new NavigationPage(new QRKod());
                //Navigationda Navigation.PushAsync(new QRKod()); önceki sayfaları kapatmadan sonraki sayfaya gitmek için kullanılacak olan komuttur.
                
                Navigation.PushAsync(new QRKod());

            };
            
            Image imageQR = new Image
            {
                Source = "qr.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };

            Label labelQR = new Label
            {
                Text = "QR Kod İşlemleri",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,

            };
            stackQrKod.Children.Add(imageQR);
            stackQrKod.Children.Add(labelQR);
            stackQrKod.GestureRecognizers.Add(TapQR);

            stackEnUst.Children.Add(stackQrKod);

            StackLayout stackViewUst = new StackLayout();
            stackViewUst.VerticalOptions = LayoutOptions.FillAndExpand;
            stackViewUst.WidthRequest = 0.7;
            stackViewUst.HorizontalOptions = LayoutOptions.FillAndExpand;

            BoxView viewEnUst = new BoxView();
            stackViewUst.BackgroundColor = Color.White;

            stackViewUst.Children.Add(viewEnUst);

            stackEnUst.Children.Add(stackViewUst);

            StackLayout stackZiraatOnay = new StackLayout();
            stackZiraatOnay.BackgroundColor = Color.FromHex("#d90c14");
            stackZiraatOnay.Orientation = StackOrientation.Vertical;
            stackZiraatOnay.WidthRequest = 290;
            stackZiraatOnay.HorizontalOptions = LayoutOptions.EndAndExpand;
            stackZiraatOnay.VerticalOptions = LayoutOptions.Start;

            Image imageZiraatOnay = new Image
            {
                Source = "checked.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelZiraatOnay = new Label
            {
                Text = "Ziraat Onay",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,
            };

            stackZiraatOnay.Children.Add(imageZiraatOnay);
            stackZiraatOnay.Children.Add(labelZiraatOnay);
       
            stackEnUst.Children.Add(stackZiraatOnay);

            stackFoot.Children.Add(stackEnUst);

            BoxView boxViewUst = new BoxView();
            boxViewUst.BackgroundColor = Color.White;
            boxViewUst.HeightRequest = 0.7;
            stackFoot.Children.Add(boxViewUst);


            //ikinci stackLayout

            StackLayout stackIkinci = new StackLayout();
            stackIkinci.BackgroundColor = Color.White;
            stackIkinci.Orientation = StackOrientation.Horizontal;
            stackIkinci.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackIkinci.BackgroundColor = Color.FromHex("#d90c14");
            stackIkinci.VerticalOptions = LayoutOptions.FillAndExpand;

            StackLayout stackYakin = new StackLayout();
            stackYakin.Orientation = StackOrientation.Vertical;
            stackYakin.BackgroundColor = Color.FromHex("#d90c14");
            stackYakin.WidthRequest = 290;
            stackYakin.VerticalOptions = LayoutOptions.Start;
            stackYakin.HorizontalOptions = LayoutOptions.StartAndExpand;

            Image imageYakin = new Image
            {
                Source = "near.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelYakin = new Label
            {
                Text = "En Yakın Ziraat",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,

            };
            stackYakin.Children.Add(imageYakin);
            stackYakin.Children.Add(labelYakin);

            stackIkinci.Children.Add(stackYakin);


            StackLayout stackViewIki = new StackLayout();
            stackViewIki.VerticalOptions = LayoutOptions.FillAndExpand;
            stackViewIki.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackViewIki.WidthRequest = 0.7;

            BoxView viewIki = new BoxView();
            viewIki.BackgroundColor = Color.White;
            viewIki.VerticalOptions = LayoutOptions.FillAndExpand;
            viewIki.HorizontalOptions = LayoutOptions.FillAndExpand;

            stackViewIki.Children.Add(viewIki);
            stackIkinci.Children.Add(stackViewIki);

            StackLayout stackHesaplama = new StackLayout();
            stackHesaplama.BackgroundColor = Color.FromHex("#d90c14");
            stackHesaplama.Orientation = StackOrientation.Vertical;
            stackHesaplama.WidthRequest = 290;
            stackHesaplama.HorizontalOptions = LayoutOptions.EndAndExpand;
            stackHesaplama.VerticalOptions = LayoutOptions.Start;

            Image imageHesaplama = new Image
            {
                Source = "calculator.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelHesaplama = new Label
            {
                Text = "Hesaplama Araçları",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,
            };

            stackHesaplama.Children.Add(imageHesaplama);
            stackHesaplama.Children.Add(labelHesaplama);

            stackIkinci.Children.Add(stackHesaplama);

            stackFoot.Children.Add(stackIkinci);


            BoxView boxViewIki = new BoxView();
            boxViewIki.BackgroundColor = Color.White;
            boxViewIki.HeightRequest = 0.7;
            stackFoot.Children.Add(boxViewIki);

            ////Üçüncü stack layout

            StackLayout stackUc = new StackLayout();
            stackUc.BackgroundColor = Color.White;
            stackUc.Orientation = StackOrientation.Horizontal;
            stackUc.BackgroundColor = Color.FromHex("#d90c14");
            stackUc.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackUc.VerticalOptions = LayoutOptions.Start;

            StackLayout stackFinans = new StackLayout();
            stackFinans.Orientation = StackOrientation.Vertical;
            stackFinans.BackgroundColor = Color.FromHex("#d90c14");
            stackFinans.WidthRequest = 290;
            stackFinans.VerticalOptions = LayoutOptions.Start;
            stackFinans.HorizontalOptions = LayoutOptions.StartAndExpand;

            Image imageFinans = new Image
            {
                Source = "diagram.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelFinans = new Label
            {
                Text = "Finansal Veriler",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,

            };
            stackFinans.Children.Add(imageFinans);
            stackFinans.Children.Add(labelFinans);

            stackUc.Children.Add(stackFinans);


            StackLayout stackViewUc = new StackLayout();
            stackViewUc.VerticalOptions = LayoutOptions.FillAndExpand;
            stackViewUc.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackViewUc.WidthRequest = 0.7;

            BoxView viewUc = new BoxView();
            viewUc.BackgroundColor = Color.White;
            viewUc.VerticalOptions = LayoutOptions.FillAndExpand;
            viewUc.HorizontalOptions = LayoutOptions.FillAndExpand;

            stackViewUc.Children.Add(viewUc);
            stackUc.Children.Add(stackViewUc);

            StackLayout stackKampanya = new StackLayout();
            stackKampanya.BackgroundColor = Color.FromHex("#d90c14");
            stackKampanya.Orientation = StackOrientation.Vertical;
            stackKampanya.WidthRequest = 290;
            stackKampanya.HorizontalOptions = LayoutOptions.EndAndExpand;
            stackKampanya.VerticalOptions = LayoutOptions.Start;

            Image imageKampanya = new Image
            {
                Source = "percent.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelKampanya = new Label
            {
                Text = "Kampanyalar",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,
            };

            stackKampanya.Children.Add(imageKampanya);
            stackKampanya.Children.Add(labelKampanya);

            stackUc.Children.Add(stackKampanya);

            stackFoot.Children.Add(stackUc);


            BoxView boxViewUc = new BoxView();
            boxViewUc.BackgroundColor = Color.White;
            boxViewUc.HeightRequest = 0.7;
            stackFoot.Children.Add(boxViewUc);


            ///// Son Layout
            StackLayout stackSon = new StackLayout();
            stackSon.BackgroundColor = Color.FromHex("#d90c14");
            stackSon.Orientation = StackOrientation.Horizontal;
            stackSon.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackSon.VerticalOptions = LayoutOptions.Start;

            StackLayout stackBasvuru = new StackLayout();
            stackBasvuru.Orientation = StackOrientation.Vertical;
            stackBasvuru.BackgroundColor = Color.FromHex("#d90c14");
            stackBasvuru.WidthRequest = 290;
            stackBasvuru.VerticalOptions = LayoutOptions.Start;
            stackBasvuru.HorizontalOptions = LayoutOptions.StartAndExpand;

            Image imageBasvuru = new Image
            {
                Source = "file.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelBasvuru = new Label
            {
                Text = "Başvurular",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,

            };
            stackBasvuru.Children.Add(imageBasvuru);
            stackBasvuru.Children.Add(labelBasvuru);

            stackSon.Children.Add(stackBasvuru);


            StackLayout stackViewSon = new StackLayout();
            stackViewSon.VerticalOptions = LayoutOptions.FillAndExpand;
            stackViewSon.HorizontalOptions = LayoutOptions.FillAndExpand;
            stackViewSon.WidthRequest = 0.7;

            BoxView viewSon = new BoxView();
            viewSon.BackgroundColor = Color.White;
            viewSon.VerticalOptions = LayoutOptions.FillAndExpand;
            viewSon.HorizontalOptions = LayoutOptions.FillAndExpand;

            stackViewSon.Children.Add(viewSon);
            stackSon.Children.Add(stackViewSon);

            StackLayout stackRandevu = new StackLayout();
            stackRandevu.BackgroundColor = Color.FromHex("#d90c14");
            stackRandevu.Orientation = StackOrientation.Vertical;
            stackRandevu.WidthRequest = 290;
            stackRandevu.HorizontalOptions = LayoutOptions.EndAndExpand;
            stackRandevu.VerticalOptions = LayoutOptions.Start;

            Image imageRandevu = new Image
            {
                Source = "contract.png",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(0, 15, 0, 0),
            };
            Label labelRandevu = new Label
            {
                Text = "Randevu Al",
                TextColor = Color.White,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Margin = new Thickness(20, 5, 20, 5),
                FontSize = 12,
            };

            stackRandevu.Children.Add(imageRandevu);
            stackRandevu.Children.Add(labelRandevu);

            stackSon.Children.Add(stackRandevu);

            stackFoot.Children.Add(stackSon);

            var tapLang = new TapGestureRecognizer();
            tapLang.Tapped += (sender, e) =>
            {
                // cast to an image
                //  DisplayAlert("uyarı", "tıklandı", "iptal");
                if (labelLang.Text == "EN")
                {
                    labelLang.Text = "TR";
                    labelQR.Text = "QR Code Transaction";
                    labelZiraatOnay.Text = "Ziraat Onay";
                    labelYakin.Text = "Closest Ziraat";
                    labelHesaplama.Text = "Calculation Tools";
                    labelFinans.Text = "Financial Data";
                    labelKampanya.Text = "Campaigns";
                    labelBasvuru.Text = "Application";
                    labelRandevu.Text = "Appointment";
                }
                else
                {
                    labelLang.Text = "EN";
                    labelQR.Text = "QR Kod İşlemleri";
                    labelZiraatOnay.Text = "Ziraat Onay";
                    labelYakin.Text = "En Yakın Ziraat";
                    labelHesaplama.Text = "Hesaplama Araçları";
                    labelFinans.Text = "Finansal veriler";
                    labelKampanya.Text = "Kampanyalar";
                    labelBasvuru.Text = "Başvurular";
                    labelRandevu.Text = "Randevu Al";
                }

                // now you have a reference to the image
            };
            stackLang.GestureRecognizers.Add(tapLang);

            //slc.Children.Add(slcTool);
            slc.Children.Add(slcAra);
            slc.Children.Add(stackFoot);

            Content = slc;

            //Toolbar kısmı

            //StackLayout slcTool = new StackLayout();
            //slcTool.Orientation = StackOrientation.Horizontal;
            //slcTool.HorizontalOptions = LayoutOptions.Start;
            //slcTool.BackgroundColor = Color.FromHex("#d90c14");

            //Image headImage = new Image();
            //headImage.Source = "headset.png";
            //headImage.HorizontalOptions = LayoutOptions.StartAndExpand;

            //Image nameImage = new Image();
            //nameImage.Source = "ziraat.png";
            //nameImage.HorizontalOptions = LayoutOptions.CenterAndExpand;

            //Label languageLabel = new Label();
            //languageLabel.Text = "EN";
            //languageLabel.TextColor = Color.White;
            //languageLabel.HorizontalOptions = LayoutOptions.EndAndExpand;

            //slcTool.Children.Add(headImage);
            //slcTool.Children.Add(nameImage);
            //slcTool.Children.Add(languageLabel);

            //Grid grid = new Grid
            //{
            //    VerticalOptions = LayoutOptions.StartAndExpand,
            //    RowDefinitions =
            //    {
            //        new RowDefinition { Height = GridLength.Star },
            //        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },  // İlk satırın nerden başlaması gerektiğini belirten kod satırı
            //        new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) }// Son satırın nerden başlaması gerektiğini belirten kod satırı
            //    },
            //    ColumnDefinitions =
            //    {
            //        new ColumnDefinition { Width = GridLength.Star },
            //        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) },// star ile yapmak istediğin kadar kolon ve satır yapabilirsin eşit büyüklükte olacaklar.
            //        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Auto) }
            //    }
            //};
            //grid.Children.Add(new Image
            //{

            //    Source = "headset.png",
            //    HeightRequest = 45,
            //    HorizontalOptions = LayoutOptions.Start,
            //    BackgroundColor = Color.FromHex("#d90c14")

            //}, 0, 0);
            //grid.Children.Add(new Image
            //{

            //    Source = "ziraat.png",
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Fill,
            //    HeightRequest = 45,
            //    BackgroundColor = Color.FromHex("#d90c14")


            //}, 1, 0);

            //grid.Children.Add(new Label
            //{

            //    Text = "Diller",
            //    TextColor = Color.White,
            //    HorizontalOptions = LayoutOptions.End,
            //    HeightRequest = 45,
            //    HorizontalTextAlignment = TextAlignment.Center,
            //    VerticalTextAlignment = TextAlignment.Center,
            //    BackgroundColor = Color.FromHex("#d90c14")

            //}, 2, 0); //önce sütun sonra satır

            //StackLayout stackToolBar = new StackLayout();
            //stackToolBar.Orientation = StackOrientation.Horizontal;
            //stackToolBar.VerticalOptions = LayoutOptions.Start;
            //stackToolBar.BackgroundColor = Color.FromHex("#d90c14");
            //stackToolBar.HorizontalOptions = LayoutOptions.StartAndExpand;

            ////head için
            //StackLayout stackHead = new StackLayout();
            //stackHead.HorizontalOptions = LayoutOptions.StartAndExpand;
            //stackHead.BackgroundColor = Color.FromHex("#d90c14");
            //stackHead.VerticalOptions = LayoutOptions.Center;

            //Image headImage = new Image();
            //headImage.Source = "headset.png";
            //stackHead.Children.Add(headImage);

            ////ziraat image için
            //StackLayout stackZiraat = new StackLayout();
            //stackZiraat.BackgroundColor = Color.FromHex("#d90c14");
            //stackZiraat.HorizontalOptions = LayoutOptions.CenterAndExpand;
            //stackZiraat.VerticalOptions = LayoutOptions.Center;

            //Image ziraatImage = new Image();
            //ziraatImage.BackgroundColor = Color.FromHex("#d90c14");
            //ziraatImage.Source = "ziraat.png";
            //stackZiraat.Children.Add(ziraatImage);

            ////language label için 
            //StackLayout stackLang = new StackLayout();
            //stackLang.HorizontalOptions = LayoutOptions.EndAndExpand;
            //stackLang.VerticalOptions = LayoutOptions.Center;

            //Label langLabel = new Label();
            //langLabel.Text = "EN";
            //langLabel.TextColor = Color.White;
            //langLabel.BackgroundColor = Color.FromHex("#d90c14");
            //stackToolBar.Children.Add(langLabel);

            //stackToolBar.Children.Add(stackHead);
            //stackToolBar.Children.Add(stackZiraat);
            //stackToolBar.Children.Add(stackLang);
            //slcTool.Children.Add(grid);


            //StackLayout anaStack = new StackLayout();

            //anaStack.Orientation = StackOrientation.Vertical;

            //StackLayout toolLayout = new StackLayout();
            //toolLayout.VerticalOptions = LayoutOptions.StartAndExpand;
            //toolLayout.HorizontalOptions = LayoutOptions.Start;
            //toolLayout.BackgroundColor = Color.FromHex("#d90c14");
            //toolLayout.Orientation = StackOrientation.Horizontal;
            //toolLayout.WidthRequest = 550;

            //toolLayout.HeightRequest = 57;

            //Image headSetImage = new Image();
            //headSetImage.Source = "headset.png";
            //headSetImage.HorizontalOptions = LayoutOptions.Start;

            //Image nameImage = new Image();
            //nameImage.Source = "ziraat.png";
            //nameImage.HorizontalOptions = LayoutOptions.Center;

            //Label languageLabel = new Label();
            //languageLabel.Text = "EN";
            //languageLabel.TextColor = Color.White;
            //languageLabel.HorizontalOptions = LayoutOptions.End;

            //toolLayout.Children.Add(headSetImage);
            //toolLayout.Children.Add(nameImage);
            //toolLayout.Children.Add(languageLabel);

            //anaStack.Children.Add(toolLayout);
            //Content = anaStack;

            //Title = "";

            //ToolbarItem toolBarItem1 = new ToolbarItem();
            //toolBarItem1.Icon = "headset.png";
            //this.ToolbarItems.Add(toolBarItem1);

            //ToolbarItem toolBarItem2 = new ToolbarItem();
            //toolBarItem2.Icon = "ziraat.png";
            //this.ToolbarItems.Add(toolBarItem2);

            //ToolbarItem toolBarItem3 = new ToolbarItem();
            //toolBarItem3.Text = "EN";
            //this.ToolbarItems.Add(toolBarItem3);

        }
    }
}
