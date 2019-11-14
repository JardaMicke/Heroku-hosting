using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{


    public interface IFox
    {
         List<Fox> ListOfFoxes { get; set; }

        List<Fox> AddFoxToList(Fox fox);
        Fox FindFoxByName(string name);
      
    }
}
