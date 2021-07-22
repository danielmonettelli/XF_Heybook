using XF_HeyBook.Models;
using System.Collections.Generic;

namespace XF_HeyBook.Services
{
    public class BookDataService : IBookDataService
    {
        public List<Book> GetAllBooks()
        {
            return BookRepository.Books;
        }
    }
}
