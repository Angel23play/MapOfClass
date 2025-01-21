using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public class Student : CommunityMember
    {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public Student(string firstname,string lastname,string phonenumber, int age, string studentId, string major) : base(firstname,lastname,age,phonenumber)
        {
            StudentId = studentId;
            Major = major;
        }

        public void Study()
        {
            Console.WriteLine($"{FirstName} {LastName} is studying {Major}.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Student ID: {StudentId}, Major: {Major}");
        }
    }
}
