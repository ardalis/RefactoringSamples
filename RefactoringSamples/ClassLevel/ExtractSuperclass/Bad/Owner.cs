using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassRefactorings.ExtractSuperclass.Bad
{
    public class Pet
    {
        public string Name { get; set; }
        public Owner Owner { get; set; }
        
        public string Display()
        {
            return Name;
        }
    }

    public class Owner
    {
        public string Name { get; set; }
        public IEnumerable<Pet> Pets { get; private set; }

        public string Render()
        {
            return Name;
        }
    }

    public class ReportGenerator
    {
        public string GenerateReport(IEnumerable<Owner> owners)
        {
            var sb = new StringBuilder();
            foreach (var owner in owners)
            {
                sb.AppendLine(owner.Render());
                if (owner.Pets.Any())
                {
                    sb.AppendLine("Pets:");
                    foreach (var pet in owner.Pets)
                    {
                        sb.AppendLine(pet.Display());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
