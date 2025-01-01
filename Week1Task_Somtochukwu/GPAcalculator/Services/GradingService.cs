using GPAcalculator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPAcalculator.DataStore;
using GPAcalculator.Helpers;
using GPAcalculator.Entities.Enums;

namespace GPAcalculator.Services
{
    public class GradingService {

        public Grade calculateGradingValues(int courseScore, int courseUnit){
            Grade result = new Grade();
            if (courseScore <= 39 && courseScore >= 0)
            {
                result.grade = ScoreGrade.F.ToString();
                result.courseGradeUnit = (int)ScoreGrade.F;
                result.remark = "Fail";
                result.courseUnitPassed = 0;
            }
            else if (courseScore <= 44 && courseScore >= 40)
            {
                result.grade = ScoreGrade.E.ToString();
                result.courseGradeUnit = (int)ScoreGrade.E;
                result.remark = "Pass";
                result.courseUnitPassed = courseUnit;
            }  
            else if (courseScore <= 49 && courseScore >= 45)
            {
                result.grade = ScoreGrade.D.ToString();
                result.courseGradeUnit = (int)ScoreGrade.D;
                result.remark = "Fair";
                result.courseUnitPassed = courseUnit;
            }
            else if (courseScore <= 59 && courseScore >= 50)
            {
                result.grade = ScoreGrade.C.ToString();
                result.courseGradeUnit = (int)ScoreGrade.C;
                result.remark = "Good";
                result.courseUnitPassed = courseUnit;
            }  
            else if (courseScore <= 69 && courseScore >= 60)
            {
                result.grade = ScoreGrade.B.ToString();
                result.courseGradeUnit = (int)ScoreGrade.B;
                result.remark = "Very good";
                result.courseUnitPassed = courseUnit;
            }
            else if (courseScore <= 100 && courseScore >= 70)
            {
                result.grade = ScoreGrade.A.ToString();
                result.courseGradeUnit = (int)ScoreGrade.A;
                result.remark = "Excellent";
                result.courseUnitPassed = courseUnit;
            }
            return result;

        }
    }
}
