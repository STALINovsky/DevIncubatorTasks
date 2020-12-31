using System;
using System.Collections.Generic;
using System.Linq;

namespace Task7
{
    class Program
    {
        static List<int> ReadAssessments()
        {
            Console.WriteLine("Type assessments, to stop just press Enter");
            var assessments = new List<int>();
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == string.Empty)
                {
                    return assessments;
                }
                else
                {
                    assessments.Add(int.Parse(userInput));
                }
            }
        }

        static double CalculateRating(params int[] assessments)
        {
            var maxAssessment = assessments.Max();
            var minAssessment = assessments.Min();

            var listOfAssessments = assessments.ToList();

            listOfAssessments.Remove(maxAssessment);
            listOfAssessments.Remove(minAssessment);

            return listOfAssessments.Average();
        }

        static void Main(string[] args)
        { 
            var assessments = ReadAssessments();
            double average = CalculateRating(assessments.ToArray());

            Console.WriteLine(average);
        }
    }
}
