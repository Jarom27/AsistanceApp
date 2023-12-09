using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Student : Person
    {
        protected List<Course> _courses;
        protected List<Asistance> _asistances;
        public Student(string name, int age, string address,string phoneNumber,string gender) : base(name,age,address,phoneNumber,gender)
        {
            _courses = new List<Course>();
            _asistances = new List<Asistance>();
        }
    }
}
