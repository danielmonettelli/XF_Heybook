using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using XF_HeyBook.Models;
using XF_HeyBook.Services;
using Xamarin.Forms;

namespace XF_HeyBook.ViewModels
{
    public class AudioBookViewModel : MyBaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IBookDataService _bookDataService;
        private readonly ICategoryDataService _categoryDataService;

        public ObservableRangeCollection<Book> Books { get; }
        public ObservableRangeCollection<Category> Categories { get; }

        public AudioBookViewModel
            (INavigationService navigationService,
            IBookDataService bookDataService,
            ICategoryDataService categoryDataService)
        {
            this._navigationService = navigationService;
            this._bookDataService = bookDataService;
            this._categoryDataService = categoryDataService;
            
            Books = new ObservableRangeCollection<Book>(_bookDataService.GetAllBooks());
            Categories = new ObservableRangeCollection<Category>(_categoryDataService.GetAllCategories());

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            BookSelectedCommand = new Command<Book>(OnBookSelectedCommand);
        }

        public ICommand BookSelectedCommand { get; private set; }

        private void OnBookSelectedCommand(Book book)
        {
            Task.Delay(350);
            _navigationService.NavigateTo("AudioBookDetailPage", book);
        }
    }
}