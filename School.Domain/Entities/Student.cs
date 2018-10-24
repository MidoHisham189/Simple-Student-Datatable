using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Entities
{
   public class Student
    {
        public int id { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public string address { get; set; }
        
        public string phone { get; set; }

        public DateTime enrollmentDate { get; set; }
    }
}
