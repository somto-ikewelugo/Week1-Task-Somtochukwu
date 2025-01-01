using System;
using System.Collections.Generic;
using System.Net;

namespace GPAcalculator.Entities;
public class Course {
    public int id;
    public string courseCode;
    public int courseUnit;
    public int courseScore;
    public string courseGrade;
    public int studentGradeUnit;
    public int courseWeightPt;
    public string courseRemark = "";
    public int courseUnitPassed;

    public Course(string courseCode, int courseUnit, int courseScore) {
        this.courseCode = courseCode;
        this.courseUnit = courseUnit;
        this.courseScore = courseScore;
        this.courseWeightPt = this.courseUnit * this.studentGradeUnit;
    }

}