using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelView
{
    public class Member
    {
        public string MemberIdentification { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset BirthDate { get; set; }

       // Member((string memberIdentification, string firstName, string lastName, DateTimeOffset birthDate)
        //{
        //    MemberIdentification = memberIdentification;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    BirthDate = birthDate;
        //}
    }
}