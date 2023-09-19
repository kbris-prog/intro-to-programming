namespace CSharpNotes;

public class UnitTest1
{
    [Fact] // attribute 
    public void Test1()
    {

    }

    [Fact]
    public void CanAddTwoSpecificInts()
    {
        // Given
        int a = 10;
        int b = 20;
        int sum;
        // When use C# add operators, should return 30
        sum = a + b;

        // this test really only tests that 10 + 20 = 30
        // Makes this a fact, a specific thing, instead of a theory
        // which would be like can add any combo of numbers 
        Assert.Equal(30, sum);
    }

    [Theory]
    [InlineData(10, 20, 30)]
    [InlineData(2, 2, 4)]
    [InlineData(10, 2, 12)]
    public void GivenAnyTwoIntegersWeCanAddThemTogether(int a, int b, int expected)
    {
        // theory uses params
        // keep trying tests until confident in theory
        int sum = a + b;
        Assert.Equal(expected, sum);
    }
}
