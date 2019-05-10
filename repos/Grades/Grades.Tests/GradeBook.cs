using System;

namespace Grades.Tests
{
    internal class GradeBook
    {
        public GradeBook()
        {
        }

        public string Name { get; internal set; }

        internal void AddGrade(int v)
        {
            throw new NotImplementedException();
        }

        internal GradeStatistics ComputeStatistics()
        {
            throw new NotImplementedException();
        }
    }
}