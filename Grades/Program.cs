using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;


            try
            {
                Console.WriteLine("Insert name");
                book.Name = Console.ReadLine(); //Create method to check if it is a valid value.
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(53);
            


            StreamWriter outputFile = File.CreateText("grades.txt");
            book.WriteGrades(outputFile);
            GradeStatistics stats = book.ComputeStatistics();
            outputFile.Close();


            WriteResult("Average grade: ", stats.AverageGrade);
            WriteResult("Highest Grade: ", stats.HighestGrade);
            WriteResult("Lowest Grade: ", stats.LowestGrade);
            WriteResult("Highest Grade Letter", stats.LetterGrade);
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"The gradebook name has changed from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }

    }
}
