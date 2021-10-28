using XF_Heybook.ViewModels;

namespace XF_Heybook.Utility
{
    public static class ViewModelLocator
    {
        public static MainHeyBookViewModel MainHeyBookViewModel { get; set; } = new MainHeyBookViewModel(App.NavigationService, App.BookDataService, App.CategoryDataService);
        public static MainHeyBookDetailViewModel MainHeyBookDetailViewModel { get; set; } = new MainHeyBookDetailViewModel(App.NavigationService, App.BookDataService);
        public static TabManagerViewModel TabManagerViewModel { get; set; } = new TabManagerViewModel(App.NavigationService, App.BookDataService, App.CategoryDataService);
    }
}
