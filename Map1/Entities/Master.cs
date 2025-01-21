using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public class Master : Teacher
    {

        public int YearsOfExperience { get; set; }

        public Master(string firstname,string lastname, int age,string phonenumber, string employeeId, decimal salary, string subject, int yearsOfExperience) : base(firstname, lastname, age,phonenumber,  employeeId, salary, subject)
        {
            YearsOfExperience = yearsOfExperience;
        }

        public void Mentor()
        {
            Console.WriteLine($"{FirstName} {LastName} is mentoring new teachers.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Years of Experience: {YearsOfExperience}");
        }
    }
}
