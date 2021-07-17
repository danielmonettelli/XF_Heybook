using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PancakeView;
using Xamarin.Forms.Xaml;
using XF_HeyBook.Models;
using XF_HeyBook.Services;
using XF_HeyBook.Utility;
using XF_HeyBook.ViewModels;

namespace XF_HeyBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AudioBookPage : ContentPage
    {
        private readonly AudioBookViewModel audioBookViewModel;

        //private Label lastElementSelected;

        public AudioBookPage()
        {
            InitializeComponent();
            BindingContext = audioBookViewModel = ViewModelLocator.AudioBookViewModel;
        }

        private void TapGestureRecognizer_StackLayout_Tapped(object sender, EventArgs e)
        {
            VisualElement surfaceCategory = sender as VisualElement;
            StackLayout parent = surfaceCategory.Parent as StackLayout;

            foreach (View child in parent.Children)
            {
                //VisualStateManager.GoToState(child, "Normal");
                ChangeFontIconColor(child, false);
            }
            //VisualStateManager.GoToState(surfaceCategory, "Selected");
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

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AudioBookDetailPage());
        }

        //private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    Book selectedItem = audioBookViewModel.Books.FirstOrDefault(b => b.Name_Book == ((TappedEventArgs)e).Parameter.ToString());

        //    if (selectedItem != null)
        //    {
        //        await Task.Delay(350);
        //        await Navigation.PushModalAsync(new AudioBookDetailPage(), true);
        //    }
        //}

        //private async void CollectionView_SelectedItem(object sender, SelectionChangedEventArgs e)
        //{
        //    object selectedItem = e.CurrentSelection.FirstOrDefault();

        //    if (selectedItem != null)
        //    {

        //        //collectionView_AudioBookForCategory.ScrollTo
        //        // (
        //        //    item: selectedItem,
        //        //    position: ScrollToPosition.Start,
        //        //    animate: true
        //        // );

        //        await Task.Delay(350);
        //        await Navigation.PushModalAsync(new AudioBookDetailPage(selectedItem as BooksViewModel), true);
        //    }

        //    collectionView_AudioBookForCategory.SelectedItem = null;
        //}


    }
}