using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Heybook.Views;
using XF_Heybook.Services;
using XF_Heybook.Utility;

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

            NavigationService.Configure(ViewNames.MainHeyBookPage, typeof(MainHeyBookPage));
            NavigationService.Configure(ViewNames.MainHeyBookDetailPage, typeof(MainHeyBookDetailPage));
            NavigationService.Configure(ViewNames.TabManagerPage, typeof(TabManagerPage));

            Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false, false);
            Sharpnado.Tabs.Initializer.Initialize(false, false);
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            MainPage = new NavigationPage(new MainHeyBookPage());
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
