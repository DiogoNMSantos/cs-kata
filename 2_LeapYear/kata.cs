namespace LeapYearKata;

using Xunit;
using FluentAssertions;

public class LeapYearShould
{
    [Fact]
    public void DoSomething() => true.Should().BeTrue();

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, false)]
    [InlineData(3, false)]
    [InlineData(100, false)]
    [InlineData(400, true)]

    public void NotBeLeapYears(int input, bool expected)
    {
        var leapYear = new LeapYear();

        bool result = leapYear.IsLeapYear(input);

        result.Should().Be(expected);
    }
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year % 400 == 0)
                return true;
            if (year % 100 == 0)
                return false;
            if (year % 4 == 0)
                return true;
            return false;
        }
    }
}


