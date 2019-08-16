using System;
using System.Linq;

namespace InheritanceRefactorings.PushDownMethod.Good
{
    public class VisibleControl : CustomWebControl
    {
        public void Render()
        {
            ApplyStyles("");
        }
        protected string ApplyStyles(object element)
        {
            return "";
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
    }
}
