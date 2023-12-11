using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Course
    {
        private string _name;
        private List<Student> _students;
        private Teacher _teacher;
        
        public Course(string name, Teacher teacher)
        {
            _name = name;
            _teacher = teacher;
            _students = new List<Student>();
        }
       
    }
}
