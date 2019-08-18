using System;
using System.Linq;

namespace ClassRefactorings.ExtractClass.Good
{
    public class Name
    {
        public Name(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }

        public string FullName()
        {
            return (FirstName + " " + MiddleName).Trim() + " " + LastName;
        }
    }

    public class Person
    {
        public Name Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        // other properties
    }
}
