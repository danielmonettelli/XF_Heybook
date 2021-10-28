using XF_Heybook.Models;
using XF_Heybook.Services;

namespace XF_Heybook.ViewModels
{
    public class MainHeyBookDetailViewModel : MyBaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IBookDataService _bookDataService;

        public Book SelectedBook { get; set; }

        public MainHeyBookDetailViewModel(
            INavigationService navigationService,
            IBookDataService bookDataService)
        {
            this._navigationService = navigationService;
            this._bookDataService = bookDataService;

            SelectedBook = new Book();

            //InitializeCommands();
        }

        //private void InitializeCommands()
        //{

        //}

        public override void Initialize(object parameter)
        {
            SelectedBook = parameter == null ? new Book() : parameter as Book;
        }
    }
}
