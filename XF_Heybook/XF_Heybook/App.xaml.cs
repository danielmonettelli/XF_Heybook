using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_HeyBook.Services;
using XF_HeyBook.Utility;
using XF_HeyBook.Views;

namespace XF_Heybook
{
    public partial class App : Application
    {
        public static NavigationService NavigationService { get; } = new NavigationService();
        public static BookDataService BookDataService { get; } = new BookDataService();
        public static CategoryDataService CategoryDataService { get; } = new CategoryDataService();

        public App()
        {
            InitializeComponent();

            NavigationService.Configure(ViewNames.AudioBookPage, typeof(AudioBookPage));
            NavigationService.Configure(ViewNames.AudioBookDetailPage, typeof(AudioBookDetailPage));

            Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false, false);
            Sharpnado.Tabs.Initializer.Initialize(false, false);
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            MainPage = new NavigationPage(new AudioBookPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
