using System;
using System.Linq;

namespace InheritanceRefactorings.PullUpMethod.Good
{
    public class Grid : CustomWebControl
    {
        protected override string ApplyStyles(object element) { return ""; }
    }
    public class RichTextBox : CustomWebControl
    {
        protected override string ApplyStyles(object element) { return ""; }
    }
    public abstract class CustomWebControl
    {
        public void Render()
        {
            ApplyStyles("");
        }
        protected abstract string ApplyStyles(object element);
    }
}
