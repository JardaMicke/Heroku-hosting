using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebShop.Models
{
    public class WebShopItems
    {
       public string Name { get; set; }
       public string Description { get; set; }
       public int Price { get; set; }
       public int QuantityOfStock { get; set; }

        public WebShopItems(string name, string description, int price, int quantityOfStock)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.QuantityOfStock = quantityOfStock;
        }        
    }

   
}
