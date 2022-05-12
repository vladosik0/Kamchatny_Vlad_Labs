using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
   public class Student:IComparable<Student>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Grade { get; set; }
        public string GroupNubmer { get; set; }
        public int[] Marks { get; set; }
           
        public Student(string firstName,string middleName,string lastName,DateTime yearOfBirth,int grade, string groupNumber,int[] marks)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = yearOfBirth;
            Grade = grade;
            GroupNubmer = groupNumber;
            Marks = new int[5];
            Marks = marks;
        }
        public string GetFullName()
        {
            return LastName + " " + FirstName + " " + MiddleName;
        }
        public float GetAverageMark()
        {
            float result = 0;
            for(int i=0;i<Marks.Length;i++)
            {
                result += Marks[i];
            }
            return result / (float)Marks.Length;
        }
        public void Print()
        {
            Console.Write($"Full name: {LastName} {FirstName} {MiddleName} Date of birth: {DateOfBirth} Grade: {Grade} Group number: {GroupNubmer} ");
            Console.Write("Marks on 5 subjects: ");
            for(int i=0;i<5;i++)
            {
                Console.Write(Marks[i]+" ");
            }
            Console.WriteLine();
        }
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if(student==null)
            {
                return false;
            }
            return student.LastName.Equals(LastName)&&student.FirstName.Equals(FirstName)&&student.MiddleName.Equals(MiddleName);
        }
        public override int GetHashCode()
        {
            int marks=0;
            for(int i=0;i<Marks.Length;i++)
            {
                marks += Marks[i];
            }
                return Grade + marks;
           
        }

        public int CompareTo(Student otherStudent)
        {
            if (this.Grade > otherStudent.Grade)
            {
                return 1;
                /*temp_student = StudentsList[j + 1];
                StudentsList[j + 1] = StudentsList[j];
                StudentsList[j] = temp_student;*/
            }
            else if (this.Grade == otherStudent.Grade)
            {
                /*if (SortByAlphabet(StudentsList[j], StudentsList[j + 1]).Equals(StudentsList[j + 1]))
                {
                    temp_student = StudentsList[j + 1];
                    StudentsList[j + 1] = StudentsList[j];
                    StudentsList[j] = temp_student;
                }
                else
                {
                    continue;
                }*/
                return this.GetFullName().CompareTo(otherStudent.GetFullName());

            }
            else
            {
                return -1;
            }
        }
    }
}
