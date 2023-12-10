using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Provider;

namespace AsistanceApp.Models
{
    public class Person
    {
       
        protected string? _name;
        protected int _age;
        protected string? _address;
        protected string? _phoneNumber;
        protected string? _gender;
        protected DateTime _birthdate;

        public Person(string name, int age, string address, string phoneNumber, string gender)
        {
            _name = name;
            _age = age;
            _address = address;
            _phoneNumber = phoneNumber;
            _gender = gender;
        }
        public string GetName()
        {
            return _name;
        }
        public int GetAge()
        {
            return _age;
        }
        public string GetAddress()
        {
            return _address;
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public string GetGender()
        {
            return _gender;
        }
        public virtual string GetInfo()
        {
            return $"{_name}, {_address}, {_phoneNumber}, {_age}, {_gender}";
        }
    }
}
