using DebugMe;

namespace TestProject1;

public class UnitTest1
{
    [Theory]
    [InlineData("NotLower", false)]
    [InlineData("islower", true)]
    public void TestLowerCase(string str, bool expected)
    {
        Assert.Equal(expected, StringAnalyzer.IsLowerCase(str));
    }
    
    [Theory]
    [InlineData(3, 40)]
    [InlineData(-2, -1)]
    [InlineData(0, 1)]
    [InlineData(36, 225141952945498681)]
    public void TestPowerSum(int n, long expected)
    {
        Assert.Equal(expected, Powers.PowerSum(n));
    }
    
    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(4, 4, 256)]
    public void TestPower(int x, int n, int expected)
    {
        Assert.Equal(expected, Powers.Power(x, n));
    }
}