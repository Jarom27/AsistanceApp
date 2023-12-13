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
        public string ID { get; set; }
        private string _name;
        private List<Student> _students;
        private string _teacher;
        public Course()
        {
            _students = new List<Student>();
        }
        
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
        public override bool Equals(object? obj)
        {
            var course = obj as Course;
            if(course != null)
            {
                return course.GetId() == _id;
            }
            return false;
        }

    }
}
