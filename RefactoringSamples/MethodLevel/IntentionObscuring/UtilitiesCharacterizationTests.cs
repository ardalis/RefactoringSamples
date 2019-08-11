using Xunit;

namespace RefactoringSamples.MethodLevel.IntentionObscuring
{
    public class UtilitiesCharacterizationTests
    {
        [Fact]
        public void m_otCalcReturnsXGiven40and20()
        {
            var utilities = new Utilities(thsWkd: 40, thsRte: 20);

            var result = utilities.m_otCalc();

            Assert.Equal(0, result);
        }
    }
}
