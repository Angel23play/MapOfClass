using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public class Teacher : Employee
    {
        public string Subject { get; set; }

        public Teacher(string firstname,string lastname, int age, string phonenumber,  string employeeId, decimal salary, string subject): base( firstname,lastname, age, phonenumber,  employeeId,  salary)
        {
            Subject = subject;
        }

        public void Teach()
        {
            Console.WriteLine($"{FirstName} {LastName} is teaching {Subject}.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"FirstName: {FirstName},LastName: {LastName}, Age: {Age}, Employee ID: {EmployeeId}, Salary: {Salary:C}, Subject: {Subject}");
        }
    }
}