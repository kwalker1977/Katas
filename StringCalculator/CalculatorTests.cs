

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");
     

        Assert.Equal(0, result);
    }

    [Fact]
    public void ConvertSingleIntergerToString()
    {
		var calculator = new Calculator();

        var result = calculator.Add("3");

        Assert.Equal(3, result);
	}
}
