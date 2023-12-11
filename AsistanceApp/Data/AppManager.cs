using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsistanceApp.Models;
using Microsoft.Extensions.Logging;

namespace AsistanceApp.Data
{
    public class AppManager
    {
        private List<Student> _students;
        private FileDatabase? _dataManager;
        private ILogger logger;
        public AppManager()
        {
            _students = new List<Student>();
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
            foreach (Student student in _students)
            {
                if(student.GetId() == id)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
