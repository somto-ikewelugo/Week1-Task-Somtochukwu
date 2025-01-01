using GPAcalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GPAcalculator.Helpers
{
    internal class Utility
    {
        public static void PrintCoursesTable(List<Course> courses)
        {
            Dash("-");
            WriteLine();
            WriteLine(format: "| {0, -15} | {1, -15} | {2, -10} | {3, -13} | {4, -13} | {5, -13} |", "COURSE & CODE", "COURSE UNIT", "GRADE", "GRADE-UNIT", "WEIGHT Pt.", "REMARK");
            Dash("-");
            WriteLine();
            foreach (Course course in courses)
            {
                WriteLine(format: "| {0, -15} | {1, -15} | {2, -10} | {3, -13} | {4, -13} | {5, -13} |", course.courseCode, course.courseUnit, course.courseGrade, course.studentGradeUnit, course.courseWeightPt, course.courseRemark);
            }
            Dash("-");
            WriteLine();
        }

        public static void Dash(string dash)
        {
            for (int i = 0; i < 98; i++)
            {
                Write(dash);
            }
        }

        //public static void calculate
    }
}
