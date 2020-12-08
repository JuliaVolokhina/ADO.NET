using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volokhina.ASP.NET.Entities
{    public class Employee
    {
        public int IDEmployee { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Employee() 
        { }
        public Employee(int idEmployee, string fullName, int age, string phoneNumber, string email, string address)
        {
            IDEmployee = idEmployee;
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public Employee(string fullName, int age, string phoneNumber, string email, string address)
        {
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }
        public override string ToString()
        {
            return $"{IDEmployee} {FullName} {Age} {PhoneNumber} {Email} {Address}";
        }
    }
}
