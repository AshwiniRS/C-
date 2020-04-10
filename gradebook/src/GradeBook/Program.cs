using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Grade Book");
            book.AddGrade(12.67);
            book.AddGrade(23.6);
            book.AddGrade(27.6);
            
            var stats = book.GetStatistics();
            System.Console.WriteLine($"The average grades are: {stats.Average:N2}");
            System.Console.WriteLine($"The highest grade is: {stats.High}");
            System.Console.WriteLine($"The lowest grade is: {stats.Low}");
        }
    }
}
