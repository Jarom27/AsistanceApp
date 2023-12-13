using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Asistance
    {
        private DateTime _asistanceDate;
        private Course _course;
        private string _courseId;
        

        public Asistance(string date)
        {
            _course = new Course();
            _asistanceDate = DateTime.Parse(date);
            _courseId = _course.GetId();
        }
        public Course GetCourse()
        {
            return _course;
        }
        public void SetCourse(Course course)
        {
            _course = course;
        }
        public string GetTime()
        {
            return _asistanceDate.ToShortDateString();
        }
        public string GetCourseID()
        {
            return _courseId;
        }

    }
}
