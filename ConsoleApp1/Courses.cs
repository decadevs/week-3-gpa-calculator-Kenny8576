using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Courses
    {
        public string courseName {  get; set; }
        public int courseCode { get; set; }
        public int courseUnit { get; set; }
        public double courseScore { get; set; }

        public Courses(string courseName, int courseCode, int courseUnit, double courseScore)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseUnit = courseUnit;
            this.courseScore = courseScore;
        }
    }
}
