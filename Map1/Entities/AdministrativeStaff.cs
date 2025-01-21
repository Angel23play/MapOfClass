using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
        public class AdministrativeStaff : Employee
    {
        public string Department { get; set; }

        public AdministrativeStaff(string firstname,string lastname, int age, string phonenumber,  string employeeId, decimal salary,string department) : base(firstname,lastname, age, phonenumber, employeeId, salary)
        {
            Department = department;
        }

        public void ManageDepartment()
        {
            Console.WriteLine($"{FirstName} {LastName} is managing the {Department} department.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}, Employee ID: {EmployeeId}, Salary: {Salary:C}, Department: {Department}");
        }
    }
}