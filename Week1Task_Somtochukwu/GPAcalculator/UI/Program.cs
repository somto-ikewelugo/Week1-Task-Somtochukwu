using System;
using System.Collections.Generic;
using System.Net;
using GPAcalculator.Entities;
using GPAcalculator.DataStore;
using GPAcalculator.Services;
using GPAcalculator.Helpers;

namespace GPAcalculator.UI;

public class Program {
    public static void Main(string[] args) {
        CourseService courseService= new CourseService();
        StudentService studentService= new StudentService();

        Data data = new Data();
        string choice = "";
        
        do {
            Console.WriteLine("Type course code and press ENTER: ");
            string courseCode= Console.ReadLine();

            Console.WriteLine("Type course unit and press ENTER: ");
            string courseUnit=  Console.ReadLine();

            Console.WriteLine("Type course score and press ENTER: ");
            string courseScore= Console.ReadLine();

            Course course = courseService.createCourse(courseScore, courseCode, courseUnit);
            data.courses.Add(course);

            Console.WriteLine("Calculate GPA? Y for Yes, N for No");
            choice = Console.ReadLine().ToUpper();
        } while (choice != "Y");

        Student student = studentService.calculateStudentTotals(data.courses);
        Utility.PrintCoursesTable(data.courses);        
        

        Console.WriteLine($"Total Course Unit Registered is {student.totalCourseUnit}\nTotal Course Unit Passed is {student.totalCourseUnitPassed}\nTotal Weight Point is {student.totalWeightPt}\nYour GPA is = {student.GPA} to 2 decimal places.");

    }
}