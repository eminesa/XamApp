using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ZiraatApp.Views
{
    class QRParaCekme : TabbedPage
    {
        public QRParaCekme()
        {

            Title = "Ziraat Bankası";
            
            Children.Add(new TabbedPages.Bireysel());
            Children.Add(new TabbedPages.Kurumsal());
        }
    }
}
