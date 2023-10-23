using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    [Fact]
    public void ShouldSum5And10AndReturn15()
    {
        int num1 = 5, num2 = 10;

        int sum = CalculatorImp.Sum(num1, num2);

        Assert.Equal(15, sum);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(7)]
    [InlineData(18)]
    [InlineData(23)]
    [InlineData(34)]
    public void ShouldCorrectlyAssertIfIntegersAreEven(int number)
    {
        bool result = CalculatorImp.IsEven(number);

        Assert.Equal(!int.IsOddInteger(number), result);
    }

    [Theory]
    [InlineData(new int[] { 41, 52 })]
    [InlineData(new int[] { 69, 76, 85 })]
    public void ShouldCorrectlyAssertIfIntegersInAnArrayAreEven(int[] numbers)
    {
        Assert.All(numbers, num => {
            bool result = CalculatorImp.IsEven(num);
            Assert.Equal(!int.IsOddInteger(num), result);
        });
    }
}