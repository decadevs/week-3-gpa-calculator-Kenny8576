using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        public static double calculator(List<Courses> courses) {
            if(courses == null)
                throw new ArgumentNullException(nameof(courses));

            double qualityPoint = 0;
            double courseUnit = 0;

            foreach(var course in courses)
            {
                qualityPoint += course.courseUnit * GetGradeUnit(course.courseScore);
                courseUnit += course.courseUnit;
            }

            var stdGPA = qualityPoint / courseUnit;

            return stdGPA;
        }

        public static int GetGradeUnit(double courseScore)
        {
            int gradeUnit = 0;

            if(courseScore >= 70)
            {
                gradeUnit = 5;
            }
            else if(courseScore <=69 || courseScore >= 60)
            {
                gradeUnit = 4;
            }
            else if(courseScore <= 59 || courseScore >= 50)
            {
                gradeUnit = 3;
            }
            else if (courseScore <= 49 || courseScore >= 40)
            {
                gradeUnit = 2;
            }
            else if (courseScore <= 39 || courseScore >= 30)
            {
                gradeUnit = 1;
            }
            else
            {
                gradeUnit = 0;
            }

            return gradeUnit;


        }
    }
}
