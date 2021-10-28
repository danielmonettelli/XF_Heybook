using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Heybook.Utility;

namespace XF_Heybook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabManagerPage : ContentPage
    {
        public TabManagerPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.TabManagerViewModel;
        }
    }
}