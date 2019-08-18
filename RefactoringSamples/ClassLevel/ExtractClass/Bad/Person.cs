using System;
using System.Linq;

namespace ClassRefactorings.ExtractClass.Bad
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // other properties

        public string FullName()
        {
            return (FirstName + " " + MiddleName).Trim() + " " + LastName;
        }
    }
}
