using System.Collections.Generic;

namespace XF_HeyBook.Models
{
    public static class BookRepository
    {
        static BookRepository()
        {
            if (Books == null)
            {
                Books = new List<Book>
                {
                new Book
                {
                    Id_Book=1,
                    Name_Book="Brave New World",
                    Author_Book="Aldous H.",
                    Price_Book=14.25,
                    Popularity_Level_Book=4.1,
                    Popularity_Counter_Book=94,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/640ac4569c9080669184da4c57f694ccf6541ed2/Books/SVGs/svg_brave_new_world.svg"
                },
                new Book
                {
                    Id_Book=2,
                    Name_Book="The Old Man and the Sea",
                    Author_Book="Ernest Hemingway",
                    Price_Book=19.45,
                    Popularity_Level_Book=5,
                    Popularity_Counter_Book=99,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/640ac4569c9080669184da4c57f694ccf6541ed2/Books/SVGs/svg_the_old_man_and_the_sea.svg"
                },
                new Book
                {
                    Id_Book=3,
                    Name_Book="1984",
                    Author_Book="George Orwell",
                    Price_Book=14.99,
                    Popularity_Level_Book=5,
                    Popularity_Counter_Book=58,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/640ac4569c9080669184da4c57f694ccf6541ed2/Books/SVGs/svg_1984.svg"
                },
                new Book
                {
                    Id_Book=4,
                    Name_Book="Pride and Prejudice",
                    Author_Book="Jane Austen",
                    Price_Book=19.99,
                    Popularity_Level_Book=4.6,
                    Popularity_Counter_Book=94,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/06e5ce0b954d4855bbc4a47cfb6c7c867b433616/Books/SVGs/svg_pride_and_prejudice.svg"
                },
                new Book
                {
                    Id_Book=5,
                    Name_Book="The Lord of the Flies",
                    Author_Book="William Golding",
                    Price_Book=13.49,
                    Popularity_Level_Book=3.8,
                    Popularity_Counter_Book=88,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/06e5ce0b954d4855bbc4a47cfb6c7c867b433616/Books/SVGs/svg_the_lord_of_the_flies.svg"
                },
                new Book
                {
                    Id_Book=6,
                    Name_Book="Farenheit",
                    Author_Book="J.K. Rowling",
                    Price_Book=22.49,
                    Popularity_Level_Book=4.0,
                    Popularity_Counter_Book=67,
                    Image_Book="https://raw.githubusercontent.com/danielmonettelli/Area51/06e5ce0b954d4855bbc4a47cfb6c7c867b433616/Books/SVGs/svg_farenheit.svg"
                }
                };
            }
        }

        public static List<Book> Books { get; set; }
    }
}
