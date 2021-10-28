using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XF_Heybook.Utility;

namespace XF_Heybook.Views
{
    public partial class BoughtHeyBookPage : ContentPage
    {
        public BoughtHeyBookPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.MainHeyBookViewModel;
        }
    }
}
