using XF_Heybook;
using XF_HeyBook.ViewModels;

namespace XF_HeyBook.Utility
{
    public static class ViewModelLocator
    {
        public static AudioBookViewModel AudioBookViewModel { get; set; } = new AudioBookViewModel(App.NavigationService, App.BookDataService, App.CategoryDataService);
        public static AudioBookDetailViewModel AudioBookDetailViewModel { get; set; } = new AudioBookDetailViewModel(App.NavigationService, App.BookDataService);
    }
}
