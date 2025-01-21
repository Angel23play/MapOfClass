using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public class Employee : CommunityMember
    {
        public string EmployeeId { get; set; }
        public decimal Salary { get; set; }

        public Employee(string firstname,string lastname, int age, string phonenumber,  string employeeId, decimal salary) : base(firstname,lastname,age,phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            PhoneNumber = phonenumber;
            EmployeeId = employeeId;
            Salary = salary;
        }

        public void Work()
        {
            Console.WriteLine($"{FirstName} {LastName} is working.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Employee ID: {EmployeeId}, Salary: {Salary:C}");
        }
    
    }
}