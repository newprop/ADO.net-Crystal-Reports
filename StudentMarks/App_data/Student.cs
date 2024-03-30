using System.Collections.Generic;

namespace StudentMarks.App_data
{
    internal class Student
    {



        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }

        public int ClassRoll { get; set; }


        public List<Marks> Markslist = new List<Marks>();


    }
}
