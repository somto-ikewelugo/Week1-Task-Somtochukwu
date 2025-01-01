using GPAcalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPAcalculator.DataStore;
using GPAcalculator.Helpers;
using GPAcalculator.Entities.Enums;

namespace GPAcalculator.Services{
    public class StudentService{

        public Student calculateStudentTotals(List<Course> courses){
            Student result = new Student(); 
            foreach (Course course in courses) {
                result.totalCourseUnit += course.courseUnit;
                result.totalWeightPt += course.courseWeightPt;
                result.totalCourseUnitPassed += course.courseUnitPassed;
            }
            float GPA = (float)result.totalWeightPt / (float)result.totalCourseUnit;
            result.GPA  = GPA;

            return result;
        }
    }
}