using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks.App_data
{
    internal class StudentsMarks
    {


        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }

        public int ClassRoll { get; set; }
        public string SubjectName { get; set; }
        public decimal TotalNumber { get; set; }
        public decimal ObtainedNumber { get; set; }
        public string Status => (ObtainedNumber / TotalNumber) * 100 >= 33 ? "PASS" : "FAIL";




    }
}
