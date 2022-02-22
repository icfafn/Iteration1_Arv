using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fagtilmeldingsapp.Codes
{
    internal class Semester : School
    {
        public string? SemesterNavn { get; set; }
        public string? UddannelsesLinje { get; set; }
         public Semester(string? schoolName,string? semesterNavn) : base(schoolName)
        {
            SemesterNavn = semesterNavn;
        }

        public override void SetUddannelseslinje(string? UddannelsesLinje)
        {
            UddannelsesLinje = uddannelseslinje;
        }
    }

}
