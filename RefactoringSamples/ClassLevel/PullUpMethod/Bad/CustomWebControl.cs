using System;
using System.Linq;

namespace InheritanceRefactorings.PullUpMethod.Bad
{
    public class Grid : CustomWebControl
    {
        public void Render()
        {
            ApplyStyles("");
        }
        private string ApplyStyles(object element) { return ""; }
    }
    public class RichTextBox : CustomWebControl
    {
        public void Render()
        {
            ApplyStyles("");
        }
        private string ApplyStyles(object element) { return ""; }
    }
    public class CustomWebControl
    {
    }
}
