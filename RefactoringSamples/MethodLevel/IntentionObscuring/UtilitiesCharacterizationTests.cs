using Xunit;

namespace RefactoringSamples.MethodLevel.IntentionObscuring
{
    public class UtilitiesCharacterizationTests
    {
        [Theory]
        [InlineData(40, 20, 800)]
        [InlineData(35, 20, 700)]
        [InlineData(55, 20, 1100)]
        [InlineData(60, 20, 1200)]
        [InlineData(55, 30, 1650)]
        [InlineData(60, 30, 1800)]
        public void m_otCalcReturnsExpectedValueForInputs(int thsWkd, int thsRte, int expectedResult)
        {
            var utilities = new Utilities(thsWkd, thsRte);

            var result = utilities.m_otCalc();

            Assert.Equal(expectedResult, result);
        }
    }
}
