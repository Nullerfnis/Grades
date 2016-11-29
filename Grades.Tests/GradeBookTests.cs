using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(53);
            book.AddGrade(33);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(53, result.HighestGrade);          
        }

        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(53);
            book.AddGrade(33);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(33, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16f, result.AverageGrade, 0.01);
        }

        [TestMethod]
        public void ComputeGradeLetter()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(30.5f);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual("F", result.LetterGrade);

        }
    }
}
