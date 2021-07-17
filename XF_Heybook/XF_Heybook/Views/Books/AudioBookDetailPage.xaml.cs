using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_HeyBook.Utility;

namespace XF_HeyBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AudioBookDetailPage : ContentPage
    {
        public AudioBookDetailPage()
        {
            InitializeComponent();

            BindingContext = ViewModelLocator.AudioBookDetailViewModel;
        }
    }
}