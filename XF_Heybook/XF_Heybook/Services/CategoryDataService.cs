using System.Collections.Generic;
using XF_Heybook.Models;

namespace XF_Heybook.Services
{
    public class CategoryDataService : ICategoryDataService
    {
        public List<Category> GetAllCategories()
        {
            return CategoryRepository.Categories;
        }
    }
}
