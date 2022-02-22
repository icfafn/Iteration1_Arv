using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fagtilmeldingsapp.Codes
{
    internal class School

    {
       
        public string? SchoolName, Uddannelselinje;
        public School()
        {
            Console.Write("Angiv Skole: ");
            SchoolName = Console.ReadLine();
            Console.Write("Angiv Uddannelselinje: ");
            Uddannelselinje = Console.ReadLine();
        }
    }
    
        
}
