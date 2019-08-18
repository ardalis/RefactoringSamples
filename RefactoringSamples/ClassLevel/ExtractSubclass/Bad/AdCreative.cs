using System;
using System.Linq;

namespace ClassRefactorings.ExtractSubclass.Bad
{
    public class AdCreative
    {
        public bool IsImage { get; set; }
        public string AdText { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public DateTime DateCreated { get; set; }

        public string Render()
        {
            if (IsImage)
            {
                return String.Format("<img height='{0}' width='{1}' alt='{2}' />",
                    Height, Width, AdText);
            }
            return AdText;
        }
    }
}
