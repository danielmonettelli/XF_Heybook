using System;
using System.Collections.Generic;
using System.Text;
using XF_Heybook.Services;

namespace XF_Heybook.ViewModels
{
    public class TabManagerViewModel : MyBaseViewModel
    {
        private readonly INavigationService _navigationService;
        private readonly IBookDataService _bookDataService;
        private readonly ICategoryDataService _categoryDataService;

        private int _selectedViewModelIndex = 0;

        public int SelectedViewModelIndex
        {
            get => _selectedViewModelIndex;
            set => _selectedViewModelIndex = value;
        }

        public TabManagerViewModel(INavigationService navigationService,
            IBookDataService bookDataService,
            ICategoryDataService categoryDataService)
        {
            this._navigationService = navigationService;
            this._bookDataService = bookDataService;
            this._categoryDataService = categoryDataService;

            MainHeyBookViewModel = new MainHeyBookViewModel(navigationService, bookDataService, categoryDataService);
        }

        public MainHeyBookViewModel MainHeyBookViewModel { get; set; }

    }
}
