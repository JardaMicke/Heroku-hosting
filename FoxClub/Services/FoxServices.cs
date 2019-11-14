using FoxClub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Controllers;

namespace FoxClub.Services
{
    public class FoxServices : IFox
    {
       public List<Fox> ListOfFoxes { get; set; }
      
         public FoxServices()
         {
             ListOfFoxes = new List<Fox>();
         }

        public List<Fox> AddFoxToList(Fox fox)
        {
            ListOfFoxes.Add(fox);
            return ListOfFoxes;
        }  
        
        public Fox FindFoxByName(string name)
        {
            return ListOfFoxes.Find(f => f.Name == name);
        }
    }
}
