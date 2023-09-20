namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("");
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("108", 108)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("108,2", 110)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("108,2", 110)]
    [InlineData("108,2,1,2,3,6,7,9,60", 198)]
    public void AnyAmountNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("108,2\n1", 111)]
    [InlineData("108\n2,1,2\n3,6,7\n9,60", 198)]
    public void NewLinesBetweenNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n1;2;6,9", 18)]
    public void DifferentDelimiters(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    //[Theory]
    //[InlineData("-1,2", 3)]
    //[InlineData("108,-2", 110)]
    //[InlineData("108,-2,1,2\n3,-6,7\n9,60", 198)]
    //public void NegativeNumbers(string numbers, int expected)
    //{
    //    var calculator = new StringCalculator();
    //    var result = calculator.Add(numbers);

    //    Assert.Throws<Exception>(() =>
    //    {

    //    });
    //}
}
