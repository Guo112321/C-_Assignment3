using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Classname { get; set; }
        public float Grade { get; set; }

        public Student(int id, string firstName, string lastName, int age, string gender, string classname, float grade)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Gender = gender;
            Classname = classname;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{Id.ToString()}|{FirstName}|{LastName}|{Age.ToString()}|{Gender}|{Classname}|{Grade}";
        }
    }
}
