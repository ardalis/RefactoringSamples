using System;
using System.Linq;

namespace ClassRefactorings.ExtractSubclass.Good
{
    public class AdCreative
    {
        public bool IsImage { get; set; }
        public string AdText { get; set; }
        public DateTime DateCreated { get; set; }

        public virtual string Render()
        {
            return AdText;
        }
    }

    public class ImageAdCreative : AdCreative
    {
        public bool IsImage { get { return true; } }
        public int Height { get; set; }
        public int Width { get; set; }

        public override string Render()
        {
            return String.Format("<img height='{0}' width='{1}' alt='{2}' />",
                Height, Width, AdText);
        }
    }
}
