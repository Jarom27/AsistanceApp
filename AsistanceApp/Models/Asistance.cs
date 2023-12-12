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

        public Asistance(Course course,string date)
        {
            _course = course;
            _asistanceDate = DateTime.Parse(date);
            
        }
        public Course GetCourse()
        {
            return _course;
        }
        public string GetTime()
        {
            return _asistanceDate.ToShortDateString();
        }

    }
}
