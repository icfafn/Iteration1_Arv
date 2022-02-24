using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{

    internal sealed class Semester : School
    {
        string SemesterNavn { get; set; }

        public Semester(string semesterNavn, string schoolName) : base(schoolName)
        {
            SemesterNavn = semesterNavn;
        }
    }
}
