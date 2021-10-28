using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;
using XF_Heybook.Models;
using XF_Heybook.Services;
using Xamarin.Forms;

namespace XF_Heybook.ViewModels
{
    public class MainHeyBookViewModel : MyBaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IBookDataService _bookDataService;
        private readonly ICategoryDataService _categoryDataService;

        public ObservableRangeCollection<Book> Books { get; }
        public ObservableRangeCollection<Category> Categories { get; }

        public MainHeyBookViewModel
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

        private async void OnBookSelectedCommand(Book book)
        {
            await Task.Delay(200);
            _navigationService.NavigateTo("MainHeyBookDetailPage", book);
        }
    }
}