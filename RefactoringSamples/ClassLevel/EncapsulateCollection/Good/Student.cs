using System.Collections.Generic;

namespace RefactoringSamples.ClassLevel.EncapsulateCollection.Good
{
    public class Class
    {
        public string Name { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        private readonly List<Class> _classes = new List<Class>();
        public IReadOnlyCollection<Class> Classes => _classes.AsReadOnly();

        //public IReadOnlyCollection<Class> Classes
        //{
        //    get
        //    {
        //        return _classes.AsReadOnly();
        //    }
        //}

        public void EnrollIn(Class theClass)
        {
            // perform some logic to confirm the student can enroll in this class
            _classes.Add(theClass);
        }
    }

    //public class AppDbContext : DbContext
    //{
    //    public DbSet<Student> Students { get; set; }

    //    public override OnModelCreating(ModelBuilder builder)
    //    {
    //        var navigation = builder.Metadata.FindNavigation(nameof(Student.Classes));

    //        navigation.SetPropertyAccessMode(PropertyAccessMode.Field);
    //    }
    //}

    public class RegistrationService
    {
        public void RegisterStudent(Student student, Class theClass)
        {
            student.EnrollIn(theClass);
        }
    }
}
