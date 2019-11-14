using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox 
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
       
        public Fox(string name)
        {
           this.Name = name;
        }

        public Fox(string name, string food, string drink)
        {
            this.Name = name;
            this.Food = food;
            this.Drink = drink;
      
        }
    }
}
