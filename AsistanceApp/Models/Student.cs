using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Student : Person
    {
        protected string _id;
        protected List<Course> _courses;
        protected List<Asistance> _asistances;
       
        public Student(string id,string name, int age, string address,string phoneNumber,string gender) : base(name,age,address,phoneNumber,gender)
        {
            _id = id;
            _courses = new List<Course>();
            _asistances = new List<Asistance>();
        }
        public Student():base()
        {
            _courses = new List<Course>();
            _asistances = new List<Asistance>();
        }
        public string GetId()
        {
            return _id;
        }
        public void SetCourse(Course course)
        {
            _courses.Add(course);
        }
        public void SetAsistance(int indexCourse, string date)
        {
            _asistances.Add(new Asistance(_courses[indexCourse],date));
        }
        public List<Asistance> GetAsistances()
        {
            return _asistances;
        }
        public List<Course> GetCourses()
        {
            return _courses;
        }
        public override bool Equals(object? obj)
        {
            var student = obj as Student;
            if(student != null)
            {
                return student.GetId() == _id;
            }
            return false;
        }
    }
}
