using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Teacher : Member
    {
        private List<Course> _courses;
        public Teacher(string name, int age, string address,string phoneNumber, string gender, string memberNumber): base(name,age,address,phoneNumber,gender,memberNumber)
        {
            _courses = new List<Course>();
        }
    }
}
