using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsistanceApp.Models
{
    public class Member : Person
    {
        protected string _memberNumber;
        protected DateTime _confirmationDate;

        public Member(string name, int age, string address,string phoneNumber, string gender,string memberNumber) : base(name,age,address,phoneNumber,gender)
        {
            _memberNumber = memberNumber;
        }
    }
}
