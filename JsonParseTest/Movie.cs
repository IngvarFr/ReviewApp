using System;
using System.Collections.Generic;
using System.Text;

namespace JsonParseTest
{
    public class Movie
    {
        public int Id { get; set; }
        public List<int> Grades { get; set; }
        public double AverageGrade { get; set; }
        public int TopGrades { get; set; }
    }
}
