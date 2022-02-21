using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fagtilmeldingsapp.Codes.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string? Coursename { get; set; }
        public int? Teacherid { get; set; }
    }
}
