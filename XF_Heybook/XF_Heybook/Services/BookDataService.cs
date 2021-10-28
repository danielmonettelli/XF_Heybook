using XF_Heybook.Models;
using System.Collections.Generic;

namespace XF_Heybook.Services
{
    public class BookDataService : IBookDataService
    {
        public List<Book> GetAllBooks()
        {
            return BookRepository.Books;
        }
    }
}
