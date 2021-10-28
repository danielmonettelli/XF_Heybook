using System.Collections.Generic;
using XF_Heybook.Models;

namespace XF_Heybook.Services
{
    public interface IBookDataService
    {
        List<Book> GetAllBooks();
    }
}
