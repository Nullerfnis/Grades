﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = GradeBook.MinimumGrade;
            LowestGrade = GradeBook.MaximumGrade;
        }
        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Excellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "Below average";
                        break;
                    default:
                        result = "Failed";
                        break;
                }

                return result;
            }
        }
        public string LetterGrade
        {
            get
            {
                string result;
                if(AverageGrade >=90)
                {
                    result = "A";
                }
                else if(AverageGrade >= 80)
                {
                    result = "B";
                }
                else if(AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }

        }
    }


}