using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public class ExStudent: CommunityMember
    {
        public string GraduationYear { get; set; }

        public ExStudent(string firstname,string lastname, int age, string phonenumber, string graduationYear): base(firstname,lastname,age,phonenumber)
        {
            GraduationYear = graduationYear;
        }

        public void AttendReunion()
        {
            Console.WriteLine($"{FirstName} {LastName} is attending the alumni reunion.");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Graduation Year: {GraduationYear}");
        }
    }
}