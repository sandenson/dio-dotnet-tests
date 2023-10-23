using Calculator.Services;

namespace CalculatorTests
{
    public class StringValidatorTests
    {
        [Fact]
        public void ShouldCorrectlyCountCharactersInAString()
        {
            string text = "Hello!";

            int count = StringValidator.CountCharacters(text);

            Assert.Equal(6, count);
        }
    }
}