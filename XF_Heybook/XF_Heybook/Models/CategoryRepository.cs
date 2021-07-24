using System.Collections.Generic;

namespace XF_HeyBook.Models
{
    public static class CategoryRepository
    {

        static CategoryRepository()
        {
            if (Categories == null)
            {
                Categories = new List<Category>
            {
                new Category
                {
                    Name_Category="All"
                },
                new Category
                {
                    Name_Category="New Arrivals"
                },
                new Category
                {
                    Name_Category="Popular"
                },
                new Category
                {
                    Name_Category="Recommended"
                }
                };
            }
        }

        public static List<Category> Categories { get; set; }
    }
}
