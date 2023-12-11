﻿using System;
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
        public string GetId()
        {
            return _id;
        }
        public void SetCourse(Course course)
        {
            _courses.Add(course);
        }
    }
}