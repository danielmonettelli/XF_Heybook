using System.Collections.Generic;
using XF_HeyBook.Models;

namespace XF_HeyBook.Services
{
    public interface ICategoryDataService
    {
        List<Category> GetAllCategories();
    }
}
