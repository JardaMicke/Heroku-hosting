using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office.CustomUI;
using Microsoft.AspNetCore.Mvc;
using MyWebShop.Models;

namespace MyWebShop.Controllers
{    
    [Route("")]
    public class NewController : Controller
    {
        static List<WebShopItems> ItemList = new List<WebShopItems>()
        {
            new WebShopItems("Running shoes", "Nike running shoes for every day sport", 1000, 5),
            new WebShopItems("Printer", "Some HP printer that will print pages", 3000, 2),
            new WebShopItems("Coca cola", "0,5l standart coke", 25, 0),
            new WebShopItems("Wokin", "Chicken with fried rice and WOKIN sauce", 119, 10),
            new WebShopItems("T-shirt", "Blue with c corgi on bike", 300, 1)
        };

        [Route("")]
        public IActionResult WebShop()
        {
            ViewBag.items = ItemList;
            return View();
        }

        [Route("OnlyAvailable")]
        public IActionResult OnlyAvailable(int quantityOfStock)
        {
            WebShopItems itemOutOfStock = ItemList.FirstOrDefault(i => i.QuantityOfStock == 0);
            ItemList.Remove(itemOutOfStock);
            return RedirectToAction("WebShop");
        }

        [Route("ChepestFirst")]
        public IActionResult ChepestFirst(int price)
        {
            ItemList = ItemList.OrderBy(c => c.Price).ToList();
            return RedirectToAction("WebShop");
        }
    }
}