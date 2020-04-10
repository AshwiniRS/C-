using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> grades = new List<double>() { 12.67, 10.3, 34.4 };
            grades.Add(21.8);

            var result = 0.0;
            foreach(double grade in grades) {
                result += grade;
            } 

            result /= grades.Count;
            System.Console.WriteLine($"The average grades are: {result:N2}");
        }
    }
}
