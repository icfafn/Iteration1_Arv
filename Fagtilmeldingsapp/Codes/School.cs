using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fagtilmeldingsapp.Codes
{
    internal abstract class School

    {

        public string? SchoolName { get; set; }

        public School(string? schoolname)
        {
            SchoolName = schoolname;
        }

        public abstract void SetUddanelseslinje(string? uddanelsesLinje);


    }



    
    
        
}
