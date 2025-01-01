using GPAcalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPAcalculator.DataStore;
using GPAcalculator.Helpers;

namespace GPAcalculator.Services
{
    public class CourseService {

        GradingService gradingService = new GradingService();
        public Course createCourse(string courseScore, string courseCode, string courseUnit){
            Course course = new Course(courseCode, int.Parse(courseUnit), int.Parse(courseScore));
            
            Grade grade = gradingService.calculateGradingValues(course.courseScore, course.courseUnit);
            course.courseRemark = grade.remark;
            course.studentGradeUnit = grade.courseGradeUnit; 
            course.courseGrade = grade.grade;
            course.courseWeightPt = course.courseUnit * course.studentGradeUnit;
            course.courseUnitPassed = grade.courseUnitPassed;

            return course;
        }
    }
}
