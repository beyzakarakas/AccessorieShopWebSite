using System.Collections.Generic;
using System.Linq;
using BeyzanurKarakas_ErenMeral.Models;

namespace BeyzanurKarakas_ErenMeral.Data
{
    public static class ProductRepository
    {
        private static List<Product>? _products = null;

        static ProductRepository()
        {
            _products = new List<Product>
            {
                new Product {ProductId = 1, Name = "Pink Princess Heart", Price = 45, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="pinkprincess.jpg", CategoryId=1},
                new Product {ProductId = 2, Name = "Purple Princess", Price = 45, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = true, ImageUrl="purpleprincess.jpg", CategoryId=1},
                new Product {ProductId = 3, Name = "Crab", Price = 35, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.",  IsApproved = true, ImageUrl="crab.jpg", CategoryId=1},
                new Product {ProductId = 4, Name = "Snowflake", Price = 30, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="snowflake.jpg", CategoryId=1},
                new Product {ProductId = 5, Name = "Star", Price = 35, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="star.jpg", CategoryId=1},
                new Product {ProductId = 6, Name = "Scorpion", Price = 40, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="scorpio.jpg", CategoryId=1},
                new Product {ProductId = 7, Name = "Satürn", Price = 40, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="saturn.jpg", CategoryId=1},

                new Product {ProductId = 8, Name = "Angel Heart Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe4.jpg", CategoryId=2},
                new Product {ProductId = 9, Name = "Star Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe5.jpg", CategoryId=2},
                new Product {ProductId = 10, Name = "Love Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe6.jpg", CategoryId=2},
                new Product {ProductId = 11, Name = "Good Luck Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe7.jpg", CategoryId=2},
                new Product {ProductId = 12, Name = "Rainbow Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe8.jpg", CategoryId=2},
                new Product {ProductId = 13, Name = "Fish Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe9.jpg", CategoryId=2},
                new Product {ProductId = 14, Name = "Bear Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe10.jpg", CategoryId=2},

                new Product {ProductId = 15, Name = "Moon Star Ring", Price = 50, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="yuzuk1.jpg", CategoryId=3},
                new Product {ProductId = 16, Name = "Heart Ring", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = true, ImageUrl="yuzuk2.jpg", CategoryId=3},
                new Product {ProductId = 17, Name = "Swarovski Heart Ring", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.",  IsApproved = true, ImageUrl="yuzuk3.jpg", CategoryId=3},
                new Product {ProductId = 18, Name = "Angel Heart Ring", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="yuzuk4.jpg", CategoryId=3},
                new Product {ProductId = 19, Name = "Tiny Butterfly", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="yuzuk5.jpg", CategoryId=3},

                new Product {ProductId = 20, Name = "Flover Bracelet", Price = 65, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="bileklik1.jpg", CategoryId=4},





                new Product {ProductId = 1, Name = "Pink Princess Heart", Price = 45, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="pinkprincess.jpg", CategoryId=6},
                new Product {ProductId = 2, Name = "Purple Princess", Price = 45, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = true, ImageUrl="purpleprincess.jpg", CategoryId=6},
                new Product {ProductId = 3, Name = "Crab", Price = 35, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.",  IsApproved = true, ImageUrl="crab.jpg", CategoryId=6},
                new Product {ProductId = 4, Name = "Snowflake", Price = 30, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="snowflake.jpg", CategoryId=6},
                new Product {ProductId = 5, Name = "Star", Price = 35, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="star.jpg", CategoryId=6},
                new Product {ProductId = 6, Name = "Scorpion", Price = 40, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="scorpio.jpg", CategoryId=6},
                new Product {ProductId = 7, Name = "Satürn", Price = 40, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="saturn.jpg", CategoryId=6},
                new Product {ProductId = 8, Name = "Angel Heart Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe4.jpg", CategoryId=6},
                new Product {ProductId = 9, Name = "Star Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe5.jpg", CategoryId=6},
                new Product {ProductId = 10, Name = "Love Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe6.jpg", CategoryId=6},
                new Product {ProductId = 11, Name = "Good Luck Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe7.jpg", CategoryId=6},
                new Product {ProductId = 12, Name = "Rainbow Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe8.jpg", CategoryId=6},
                new Product {ProductId = 13, Name = "Fish Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe9.jpg", CategoryId=6},
                new Product {ProductId = 14, Name = "Bear Earring", Price = 60, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="kupe10.jpg", CategoryId=6},
                new Product {ProductId = 15, Name = "Moon Star Ring", Price = 50, Description = "Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="yuzuk1.jpg", CategoryId=6},
                new Product {ProductId = 16, Name = "Heart Ring", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = true, ImageUrl="yuzuk2.jpg", CategoryId=6},
                new Product {ProductId = 17, Name = "Swarovski Heart Ring", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.",  IsApproved = true, ImageUrl="yuzuk3.jpg", CategoryId=6},
                new Product {ProductId = 18, Name = "Angel Heart Ring", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="yuzuk4.jpg", CategoryId=6},
                new Product {ProductId = 19, Name = "Tiny Butterfly", Price = 50, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="yuzuk5.jpg", CategoryId=6},
                new Product {ProductId = 20, Name = "Flover Bracelet", Price = 65, Description = " Çelik/Vip kategorisindeki tüm ürünlerimiz kararmaz,paslanmaz ve 2 yıl garantilidir.", IsApproved = false, ImageUrl="bileklik1.jpg", CategoryId=6},
            };
        }

        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product? GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }

        public static void EditProduct(Product product)
        {
            foreach (var p in _products)
            {
                if (p.ProductId == product.ProductId)
                {
                    p.Name = product.Name;
                    p.Price = product.Price;
                    p.ImageUrl = product.ImageUrl;
                    p.Description = product.Description;
                    p.IsApproved = product.IsApproved;
                    p.CategoryId = product.CategoryId;
                }
            }
        }

        public static void DeleteProduct(int id)
        {
            var product = GetProductById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}