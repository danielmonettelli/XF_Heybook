using System.Collections.Generic;
using XF_HeyBook.Models;

namespace XF_HeyBook.Services
{
    public class CategoryDataService : ICategoryDataService
    {
        public List<Category> GetAllCategories()
        {
            return CategoryRepository.Categories;
        }
    }
}
