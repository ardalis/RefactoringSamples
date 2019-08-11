using System;

namespace RefactoringSamples.MethodLevel.IntentionObscuring
{
    public class Utilities
    {
        private readonly int iThsRte;
        private readonly int iThsWkd;

        public Utilities(int thsWkd, int thsRte)
        {
            iThsRte = thsRte;
            iThsWkd = thsWkd;
        }

        public int m_otCalc()
        {
            return iThsWkd * iThsRte +
                (int)Math.Round(0.5 * iThsRte * Math.Max(0, iThsWkd - 400));
        }
    }
}
