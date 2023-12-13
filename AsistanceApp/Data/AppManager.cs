using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistanceApp.Components.Pages;
using AsistanceApp.Models;
using Microsoft.Extensions.Logging;

namespace AsistanceApp.Data
{
    public class AppManager
    {
        private List<Student> _students;
        private List<Course> _courses;
        private FileDatabase? _dataManager;
        private ILogger _logger;
        public AppManager()
        {
            _students = new List<Student>();
            _courses = new List<Course>();
            using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddDebug());
            _logger = factory.CreateLogger<AppManager>();

        }
        


        public async Task<List<Student>> GetAllStudents()
        {
            _dataManager = new FileDatabase();
            string data = await _dataManager.GetQuery("Students.txt");
            string[] lines = data.Split("\n");
            foreach(string line in lines)
            {
                string[] record = line.Split(",");
                _students.Add(new Student(record[0], record[1], int.Parse(record[2]), record[3], record[4], record[5]));
            }
            return _students;
        }
        public async Task<Student> FindStudentById(string id)
        {
            await GetAllStudents();
            await GetAllCourses();
            await FillAllData();
            await FillAsistancesById(id);
            foreach (Student student in _students)
            {
                if(student.GetId() == id)
                {
                    return student;
                }
            }
            return null;
        }
        public async Task FillAsistancesById(string id)
        {
            _dataManager = new FileDatabase();
            string data = await _dataManager.GetQuery("Asistances.txt");
            string[] lines = data.Split("\n");
            int studentIndex = _students.FindIndex(x => x.GetId().Trim() == id);
            Student student = _students[studentIndex];
            foreach (string line in lines)
            {
                string[] record = line.Split(",");
                if (record[0] == id)
                {
                    int courseIndex = student.GetCourses().FindIndex(x => x.GetId() == record[1]);
                    student.SetAsistance(courseIndex, record[2].Trim());
                }
            }
        }
        public async Task FillAllData()
        {
            _dataManager = new FileDatabase();
            string data = await _dataManager.GetQuery("CoursesStudents.txt");
            string[] lines = data.Split("\n");
            foreach(string line in lines)
            {
                string[] record = line.Split(",");
                int studentIndex = _students.FindIndex(x => x.GetId() == record[0]);
                int courseIndex = _courses.FindIndex(y =>
                {
                    return y.GetId() == record[1].Trim();
                });
               
                _students[studentIndex].SetCourse(_courses[courseIndex]);
                _courses[courseIndex].AddStudent(_students[studentIndex]);
            }
        }
        public async Task<List<Course>> GetAllCourses()
        {
            _dataManager = new FileDatabase();
            string data = await _dataManager.GetQuery("Courses.txt");
            string[] lines = data.Split("\n");
            foreach(string line in lines)
            {
                string[] record = line.Split(",");
                _courses.Add(new Course(record[0], record[1], record[2]));
            }
            return _courses;
        }
        public async Task<Course> FindCourseById(string id)
        {
            await GetAllCourses();
            await GetAllStudents();
            await FillAllData();
            foreach (Course course in _courses)
            {
                if (course.GetId() == id)
                {
                    return course;
                }
            }
            return null;
        }
        public async Task RecordAsistance(string studentId,Asistance asistance)
        {
            _dataManager = new FileDatabase();
            _logger.LogError(asistance.GetCourseID());
            //await _dataManager.RegisterData("Asistances.txt",$"{studentId},{asistance.GetCourse().GetId()},{asistance.GetTime()}");
        }
    }
}
