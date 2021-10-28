using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Heybook.Utility;

namespace XF_Heybook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainHeyBookPage : ContentPage
    {

        public MainHeyBookPage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.MainHeyBookViewModel;
        }

        private void TapGestureRecognizer_StackLayout_Tapped(object sender, EventArgs e)
        {
            VisualElement surfaceCategory = sender as VisualElement;
            StackLayout parent = surfaceCategory.Parent as StackLayout;

            foreach (View child in parent.Children)
            {
                ChangeFontIconColor(child, false);
            }
            ChangeFontIconColor(surfaceCategory, true);
        }

        void ChangeFontIconColor(VisualElement child, bool isSelected)
        {
            Label labelCategory = child.FindByName<Label>("LabelCategory");
            BoxView lineBox = child.FindByName<BoxView>("LineBox");

            string visualState = isSelected ? "Selected" : "Normal";
            VisualStateManager.GoToState(labelCategory, visualState);
            VisualStateManager.GoToState(lineBox, visualState);
        }

    }
}