using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace ZiraatApp.Views
{
    class Maps :ContentPage
    {
        public Maps()
        {
            var map = new Map(
           MapSpan.FromCenterAndRadius(
                   new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand,
                MapType = MapType.Street
                
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
        }
    }
}
