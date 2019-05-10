using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            IGradeTracker book = CreateGradeBook();

            //GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static GradeTracker CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResults(IGradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            foreach(float grade in book)
            {
                Console.WriteLine(grade);
            }

            Description("Average ", stats.AverageGrade);
            Description("Highest achievement is ", stats.HighestGrade);
            Description("Smallest achievement is ", stats.LowestGrade);
            Description(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(IGradeTracker book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(111);
            book.AddGrade(55.5f);
            book.AddGrade(0);
            book.AddGrade(100);
            book.AddGrade(200);
        }

        private static void GetBookName(IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Description(string descrp, string result)
        {
            Console.WriteLine($"{descrp}: {result}", descrp, result);
        }


        static void Description(string descrp, float result)
        {
            Console.WriteLine("{0}: {1}", descrp, result);
        }


    }


}
