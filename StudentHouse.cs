using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class StudentHouse
    {
        private List<Student> students;
        private int nrOfStudents;
        public StudentHouse()
        {
            students = new List<Student>();
        }

       public int CountStudents
        {
            get
            {
                return nrOfStudents;
            }
            set
             {
                nrOfStudents = value;
            }
        }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return students;
        }
        public Student GetStudent(int index)
        {
            return students[index];
        }
        
    }
}
