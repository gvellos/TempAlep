using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using temp2.Models;

namespace temp2.Controllers
{
    public class ProductsController : Controller
    {

        private static List<Products> products = new List<Products>
        {
            new Products { Name = "Pizza", Price = 10.99m },
            new Products { Name = "Milk", Price = 2.99m },
            new Products { Name = "Meat", Price = 29.99m }
        };

        public IActionResult Index()
        {
            return View(products);
        }








        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, decimal price)
        {
            var newProduct = new Products
            {
                Name = name,
                Price = price
            };

            //newProduct.Name = name;
            //newProduct.Price = price;


            products.Add(newProduct);
            return RedirectToAction("Index");
        }
    }
}
