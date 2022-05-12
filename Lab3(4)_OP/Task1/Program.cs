using System;
using System.Collections.Generic;
using System.Linq;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstStudentMarks = { 4, 4, 5, 5, 5 };
            int[] secondStudentMarks = { 4, 4, 5, 5, 4 };
            int[] thirdStudentMarks = { 2, 4, 4, 3, 3 };
            int[] fourthStudentMarks = { 5, 4, 5, 5, 5 };
            int[] fifthStudentMarks = { 1, 3, 3, 4, 5 };

            List<Student> students = new List<Student>
            {
                new Student("Pavlo","Pavlovych","Pavlenko",new DateTime(2002,5,15),3,"91",fourthStudentMarks),
                new Student("Petro","Petrovich","Petrov",new DateTime(2004,9,11),1,"11",secondStudentMarks),
                new Student("Maxym","Maxymovich","Maxymov",new DateTime(2003,8,7),2,"01",thirdStudentMarks),
                new Student("Ivan","Ivanovich","Ivanov",new DateTime(2004,3,18),1,"11",firstStudentMarks),
                new Student("Vasyl","Vasyliovich","Vasylenko",new DateTime(2002,2,25),3,"91",fifthStudentMarks),
            };
            ListOfStudents listOfStudents = new ListOfStudents(students);
            foreach(var student in listOfStudents.StudentsList)
            {
                student.Print();
            }
            Console.WriteLine("=============================================");
            listOfStudents.SortByCourse();
            foreach (var student in students)
            {
                student.Print();
            }
            listOfStudents.FindAverageMarkOnGrade("11");
            Console.WriteLine("=============================================");
            listOfStudents.FindAverageMarkOnGrade("01");
            Console.WriteLine("=============================================");
            listOfStudents.FindAverageMarkOnGrade("91");
            Console.WriteLine("=============================================");
            listOfStudents.FindTheMostSuccessfulStudentInGroup("01");
            Console.WriteLine("=============================================");
            listOfStudents.FindTheMostSuccessfulStudentInGroup("11");
            Console.WriteLine("=============================================");
            listOfStudents.FindTheMostSuccessfulStudentInGroup("91");
            Console.WriteLine("=============================================");
            listOfStudents.FindTheOldestStudent();
            Console.WriteLine("=============================================");
            listOfStudents.FindTheYoungestStudent();
            Console.WriteLine("=============================================");
            
        }
      
    }
}
