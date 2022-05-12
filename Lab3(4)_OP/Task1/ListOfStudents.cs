using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class ListOfStudents
    {
        public List<Student> StudentsList { get; set; }

        public Student this[int i]
        {
            get => StudentsList[i];
            set => StudentsList[i] = value;
        }
        public ListOfStudents(List<Student> listOfStudents)
        {
            this.StudentsList = listOfStudents;
        }
        public void SortByCourse()
        {
            var temp_student = StudentsList[0];
            for (int i = 0; i < StudentsList.Count; i++)
            {
                for (int j = 0; j + 1 < StudentsList.Count; j++)
                {
                   if(StudentsList[j].CompareTo(StudentsList[j+1])>0)
                    {
                        temp_student = StudentsList[j + 1];
                        StudentsList[j + 1] = StudentsList[j];
                        StudentsList[j] = temp_student;
                    }

                }
            }
        }
        public void FindAverageMarkOnGrade(string group)
        {
            bool repeat = false;
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (StudentsList[i].GroupNubmer.Equals(group) && !repeat)
                {
                    repeat = true;
                    int j = 0;
                    while (j < 5)
                    {
                        Console.WriteLine($"Average mark of {group} group on {j + 1} subject: {FindAverageMarkOnSubject(j, group)}");
                        j++;
                    }
                }
            }
        }
        public float FindAverageMarkOnSubject(int subject, string group)
        {
            float result = 0;
            float counter = 0;
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (StudentsList[i].GroupNubmer.Equals(group))
                {
                    result += StudentsList[i].Marks[subject];
                    counter++;
                }
            }
            return result / counter;
        }
        public void FindTheYoungestStudent()
        {
            DateTime minTime = StudentsList[0].DateOfBirth;
            int indexOfYoungestStudent = 0;

            for (int i = 1; i < StudentsList.Count; i++)
            {
                if (minTime > StudentsList[i].DateOfBirth)
                {
                    minTime = StudentsList[i].DateOfBirth;
                    indexOfYoungestStudent = i;
                }
            }
            Console.WriteLine($"The youngest student is {StudentsList[indexOfYoungestStudent].GetFullName()} Date of birth: {StudentsList[indexOfYoungestStudent].DateOfBirth.ToShortDateString()}");
        }
        public void FindTheOldestStudent()
        {
            DateTime maxTime = StudentsList[0].DateOfBirth;
            int indexOfOldestStudent = 0;

            for (int i = 1; i < StudentsList.Count; i++)
            {
                if (maxTime < StudentsList[i].DateOfBirth)
                {
                    maxTime = StudentsList[i].DateOfBirth;
                    indexOfOldestStudent = i;
                }
            }
            Console.WriteLine($"The oldest student is {StudentsList[indexOfOldestStudent].GetFullName()} Date of birth: {StudentsList[indexOfOldestStudent].DateOfBirth.ToShortDateString()}");
        }
        public void FindTheMostSuccessfulStudentInGroup(string group)
        {
            int indexOfStudent = -1;
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (StudentsList[i].GroupNubmer.Equals(group))
                {
                    indexOfStudent = i;
                    break;
                }
            }
            if (indexOfStudent == -1)
            {
                Console.WriteLine("There is no student from such a group");
                return;
            }
            for (int i = 0; i < StudentsList.Count; i++)
            {
                if (StudentsList[i].GroupNubmer.Equals(group))
                {
                    if (StudentsList[indexOfStudent].GetAverageMark() < StudentsList[i].GetAverageMark())
                    {
                        indexOfStudent = i;
                    }
                }
            }
            Console.WriteLine($"The most succesful student in {group} group is {StudentsList[indexOfStudent].GetFullName()} The average mark is {StudentsList[indexOfStudent].GetAverageMark()}");
        }
       
    }
}
