using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Course
    {
        private string _id;
        private string _name;
        private List<Student> _students;
        private string _teacher;
        
        public Course(string id,string name, string teacher)
        {
            _id = id;
            _name = name;
            _teacher = teacher;
            _students = new List<Student>();
        }
        public string GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }
        public string GetTeacher()
        {
            return _teacher;
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public List<Student>? GetStudents()
        {
            return _students;
        }
       
    }
}
