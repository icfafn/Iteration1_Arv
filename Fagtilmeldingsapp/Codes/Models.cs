using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FagTilmeldingApp.Codes
{
    internal class Course : IComparable<Course>
    {
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public int? TeacherId { get; set; }


        public int CompareTo(Course next)
        {
            return this.CourseName.CompareTo(next.CourseName);
        }
    }

}
