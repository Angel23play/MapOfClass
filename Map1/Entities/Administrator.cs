using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public class Administrator : Teacher
    {
        public Administrator(string firstname,string lastname, int age, string phonenumber,string employeeId, decimal salary, string subject) : base(firstname,lastname,age,phonenumber,employeeId,salary,subject)
        {
        }

        public void ApprovePolicies()
        {
            Console.WriteLine($"{FirstName} {LastName} is approving policies.");
        }
    }
}