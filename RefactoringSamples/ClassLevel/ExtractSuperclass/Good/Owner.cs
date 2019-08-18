using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassRefactorings.ExtractSuperclass.Good
{
    public abstract class ReportItem
    {
        public string Name { get; set; }
        public virtual string Render()
        {
            return Name;
        }
    }

    public class Pet : ReportItem
    {
        public Owner Owner { get; set; }
    }

    public class Owner : ReportItem
    {
        public IEnumerable<Pet> Pets { get; private set; }
    }

    public class ReportGenerator
    {
        public string GenerateReport(IEnumerable<Owner> owners)
        {
            var sb = new StringBuilder();
            foreach (var owner in owners)
            {
                sb.AppendLine(PrepareReportItem(owner));
                if (owner.Pets.Any())
                {
                    sb.AppendLine("Pets:");
                    foreach (var pet in owner.Pets)
                    {
                        sb.AppendLine(PrepareReportItem(pet));
                    }
                }
            }
            return sb.ToString();
        }

        public string PrepareReportItem(ReportItem reportItem)
        {
            return reportItem.Render();
        }
    }
}
