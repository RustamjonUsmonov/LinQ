using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqObj
{
    class Exam
    {
        public string Surname { get; set; }
        public string Initials { get; set; }
        public int SchoolNum { get; set; }
        public string Points { get { return $"{ Math}{Russian}{IT}"; } set { int.Parse(Points); } }
        public int Math { get; set; }
        public int Russian { get; set; }
        public int IT { get; set; }

        public string FullName { get { return $"{Surname} {Initials}"; } }
    }
}
