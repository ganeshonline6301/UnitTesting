namespace CalculatorLibrary.Tests.Unit;

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldAddTwoNumbers_WhenToNumbersAreIntegers()
    {
        var calculator = new Calculator();
        
        var result = calculator.Add(5, 2);
        
        Assert.Equal(7, result);
    }
}