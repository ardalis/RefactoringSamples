using System;
using System.Linq;

namespace InheritanceRefactorings.ReplaceTypeCodeWithClass.Good
{
    public class BloodGroup
    {
        public static readonly BloodGroup O = new BloodGroup(0);
        public static readonly BloodGroup A = new BloodGroup(1);
        public static readonly BloodGroup B = new BloodGroup(2);
        public static readonly BloodGroup AB = new BloodGroup(3);
        private static readonly BloodGroup[] _values = { O, A, B, AB };

        public int Code { get; private set; }
        public BloodGroup(int code)
        {
            this.Code = code;
        }

        // removed
        //public static BloodGroup Create(int arg)
        //{
        //    return _values[arg];
        //}
    }

    public class Person
    {
        // These can be removed
        //public static readonly int O = BloodGroup.O.Code;
        //public static readonly int A = BloodGroup.A.Code;
        //public static readonly int B = BloodGroup.B.Code;
        //public static readonly int AB = BloodGroup.AB.Code;

        // Add new property, ctor with the new class
        public BloodGroup BloodGroup { get; set; }
        public Person(BloodGroup bloodGroup)
        {
            this.BloodGroup = bloodGroup;
        }

        // Can be removed
        #region Old Int-Based Code
        //private BloodGroup _bloodGroup;

        //public int BloodCodeGroup
        //{
        //    get
        //    {
        //        return _bloodGroup.Code;
        //    }
        //    set
        //    {
        //        _bloodGroup = BloodGroup.Create(value);
        //    }
        //}

        //public Person(int bloodGroup)
        //{
        //    _bloodGroup = BloodGroup.Create(bloodGroup);
        //}
        #endregion
    }

    public class Client
    {
        public void Main()
        {
            //Person thePerson = new Person(Person.A);
            Person thePerson = new Person(BloodGroup.A);

            //int bloodCode = thePerson.BloodCodeGroup;
            int bloodCode = thePerson.BloodGroup.Code;

            //thePerson.BloodCodeGroup = Person.AB;
            thePerson.BloodGroup = BloodGroup.AB;
        }
    }
}
