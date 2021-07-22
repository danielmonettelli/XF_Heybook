using XF_HeyBook.Models;
using XF_HeyBook.Services;

namespace XF_HeyBook.ViewModels
{
    public class AudioBookDetailViewModel : MyBaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IBookDataService _bookDataService;

        public Book SelectedBook { get; set; }

        public AudioBookDetailViewModel(
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
