namespace XF_HeyBook.Models
{
    public class Book
    {
        private int _id_Book;
        private string _name_Book;
        private string _author_Book;
        private double _price_Book;
        private double _popularity_Level_Book;
        private double _popularity_Counter_Book;
        private string _image_Book;

        public int Id_Book
        {
            get => _id_Book;
            set => _id_Book = value;
        }

        public string Name_Book
        {
            get => _name_Book;
            set => _name_Book = value;
        }

        public string Author_Book
        {
            get => _author_Book;
            set => _author_Book = value;
        }

        public double Price_Book
        {
            get => _price_Book;
            set => _price_Book = value;
        }

        public double Popularity_Level_Book
        {
            get => _popularity_Level_Book;
            set => _popularity_Level_Book = value;
        }

        public double Popularity_Counter_Book
        {
            get => _popularity_Counter_Book;
            set => _popularity_Counter_Book = value;
        }

        public string Image_Book
        {
            get => _image_Book;
            set => _image_Book = value;
        }
    }
}
