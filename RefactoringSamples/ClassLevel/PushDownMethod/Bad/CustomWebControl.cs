using System;
using System.Linq;

namespace InheritanceRefactorings.PushDownMethod.Bad
{
    public class VisibleControl : CustomWebControl
    {
        public void Render()
        {
            ApplyStyles("");
        }
    }
    public class InvisibleControl : CustomWebControl
    {
        public void Render()
        {
        }
    }
    public abstract class CustomWebControl
    {
        protected string ApplyStyles(object element)
        {
            return "";
        }
    }
}
