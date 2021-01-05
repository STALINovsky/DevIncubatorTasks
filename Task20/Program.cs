using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task20
{
    class Program
    {
        /// <summary>
        /// Calculate average score by studentList
        /// </summary>
        /// <param name="students"></param>
        /// <returns>average score</returns>
        static double AverageGradeOfStudents(IEnumerable<Student> students)
        {
            return students.Average((student) => student.AverageGrade);
        }

        /// <summary>
        /// Select students with low than average score
        /// </summary>
        /// <param name="students"></param>
        /// <returns>students with low than average score</returns>
        static IEnumerable<Student> StudentsWithLowThanAverageScore(List<Student> students)
        {
            var averageStudentsScore = AverageGradeOfStudents(students);

            return students.Where(student => student.AverageGrade < averageStudentsScore);
        }

        /// <summary>
        /// Showing list of students on console
        /// </summary>
        /// <param name="students"></param>
        static void PrintStudents(IEnumerable<Student> students)
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"The school number {Student.SCHOOL_NUMBER} has:");
            descriptionBuilder.AppendJoin('\n', students);
            Console.WriteLine(descriptionBuilder.ToString());
        }

        static void Main(string[] args)
        {
            //creating student list
            var students = Student.ReadStudents();
            //showing average score
            Console.WriteLine($"Average score = {AverageGradeOfStudents(students)}");

            //showing students with low than average score
            var studentsWithLowThanAverageScore = StudentsWithLowThanAverageScore(students);
            Console.WriteLine("students with low than average score:");
            PrintStudents(studentsWithLowThanAverageScore);
        }
    }
}
