using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class University
    {
        private List<Student> students;

        public University()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            students.Sort((s1, s2) => s1.Score.CompareTo(s2.Score));
        }

        public string FindStudentByScore(int score)
        {
            int left = 0, right = students.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (students[mid].Score == score)
                    return students[mid].Name;
                else if (students[mid].Score < score)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return "Nqma takuv student";
        }
    }
}

