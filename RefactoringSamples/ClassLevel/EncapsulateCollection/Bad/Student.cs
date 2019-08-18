using System.Collections.Generic;

namespace RefactoringSamples.ClassLevel.EncapsulateCollection.Bad
{
    public class Class
    {
        public string Name { get; set; }
    }

    public class Student
    {
        public string Name { get; set;}
        public List<Class> Classes;
    }

    public class RegistrationService
    {
        public void RegisterStudent(Student student, Class theClass)
        {
            var currentClasses = student.Classes;
            // perform some logic to confirm the student can enroll in this class
            currentClasses.Add(theClass);
        }
    }
}
