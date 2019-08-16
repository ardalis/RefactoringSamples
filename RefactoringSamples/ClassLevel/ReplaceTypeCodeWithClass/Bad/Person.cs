using System;
using System.Linq;

namespace InheritanceRefactorings.ReplaceTypeCodeWithClass.Bad
{
    public class Person
    {
        public static readonly int O = 0;
        public static readonly int A = 1;
        public static readonly int B = 2;
        public static readonly int AB = 3;

        public int BloodGroup { get; set; }
        public Person(int bloodGroup)
        {
            this.BloodGroup = bloodGroup;
        }
    }

    public class Client
    {
        public void Main()
        {
            Person thePerson = new Person(Person.A);

            int bloodCode = thePerson.BloodGroup;

            thePerson.BloodGroup = Person.AB;

        }
    }
}
