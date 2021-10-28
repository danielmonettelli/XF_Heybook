using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XF_Heybook.Utility;

namespace XF_Heybook.Views
{
    public partial class BookmarkHeyBookPage : ContentPage
    {
        public BookmarkHeyBookPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.MainHeyBookViewModel;
        }
    }
}
