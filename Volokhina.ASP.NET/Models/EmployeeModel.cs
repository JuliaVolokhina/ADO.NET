using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Volokhina.ASP.NET.Models
{
    public class EmployeeModel
    {
        public int IDEmployee { get; set; }

        public string FullName { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public EmployeeModel(int iDEmployee, string fullName, int age, string phoneNumber, string email, string address)
        {
            IDEmployee = iDEmployee;
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }
    }
}
