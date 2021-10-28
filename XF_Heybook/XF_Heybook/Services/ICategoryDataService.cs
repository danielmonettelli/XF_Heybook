using System.Collections.Generic;
using XF_Heybook.Models;

namespace XF_Heybook.Services
{
    public interface ICategoryDataService
    {
        List<Category> GetAllCategories();
    }
}
