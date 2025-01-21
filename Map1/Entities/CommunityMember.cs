using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Map1.Entities
{
    public abstract class CommunityMember
    {
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName{ get; set;}
        public string PhoneNumber { get; set;}
        public int Age { get; set; }


        public CommunityMember(string firstname,string lastname, int age, string phonenumber)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
            PhoneNumber = phonenumber;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"FirstName: {FirstName},LastName: {LastName} ,Age: {Age}, PhoneNumber: {PhoneNumber} ");
        }
    }
}