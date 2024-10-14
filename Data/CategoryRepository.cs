using System.Collections.Generic;

namespace BeyzanurKarakas_ErenMeral.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId = 6, Name = "Tüm Kategoriler", Description = "Tüm Kategoriler"},
                new Category {CategoryId = 1, Name = "Kolye", Description = "Kolye Kategorisi"},
                new Category {CategoryId = 2, Name = "Küpe", Description = "Bileklik Kategorisi"},
                new Category {CategoryId = 3, Name = "Yüzük", Description = "Yüzük Kategorisi"},
                new Category {CategoryId = 4, Name = "Bileklik", Description = "Küpe Kategorisi"},
                new Category {CategoryId = 5, Name = "Gözlük", Description = "Gözlük Kategorisi"},
            };
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        
        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(c=>c.CategoryId == id);
        }
    }


}