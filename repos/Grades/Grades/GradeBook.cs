﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");

            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public override void WriteGrades(TextWriter place)
        {
            for (int i = grades.Count; i > 0; i--)
            {
                place.WriteLine(grades[i - 1]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        protected List<float> grades;

       
    }


}

