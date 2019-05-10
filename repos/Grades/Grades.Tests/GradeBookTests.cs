using Grades;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        
        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(10, result.LowestGrade);

        }
        [TestMethod]
        internal void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);

        }
    }
}
