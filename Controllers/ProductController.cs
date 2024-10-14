using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using BeyzanurKarakas_ErenMeral.Models;
using Microsoft.AspNetCore.Mvc;
using BeyzanurKarakas_ErenMeral.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List(int? id, string q)
        {
            var products = ProductRepository.Products;
            if (id != null)
            {
                //bu kod bloğu filtreleme işleminde kullanılır
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                //bu kod bloğu search button'da girilen değerin aranmasını sağlar
                products = products.Where(i => i.Name.ToLower().Contains(q.ToLower()) || i.Description.Contains(q)).ToList();
            }

            var ProductViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(ProductViewModel);
        }

        public IActionResult Details(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }

        [HttpGet] //bu actionresult değerleri varsayılan olarak httpget protokolünde gelirler. biz yazmasak da varsayılan olarak yüklenirler. 
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(new Product());
        }

        [HttpPost] // create.cshtml sayfasındaki form post methoduyla yüklendiği için belirtilmesi gerekmektedir. 
        public IActionResult Create(Product p)
        {
            // parametre olarak girilen bilgiler formdan gelecektir.
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);
                return RedirectToAction("list");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(p);
            //uygulama db bağlantısına sahip olmadığı için, ürün eklesek de uygulamayı tekrardan başlatınca eklenen ürün silinir.
            //sebebi eklenen ürünün geçici olarak bellekte tutulmasıdır.
            //kalıcı olarak ürün eklemek için db bağlantılarını yapmamız gerekir.  
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
            ProductRepository.EditProduct(p);
            return RedirectToAction("list");
        }

        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("list");
        }



    }
}