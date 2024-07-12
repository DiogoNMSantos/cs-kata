namespace FizzBuzzKata;

using Xunit;
using FluentAssertions;

public class FizzBuzzShould
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    [InlineData(4, "4")]

    public void ConvertNonMultipleOfThreeNorFiveToString(int input, string expected)
    {
        var fizzbuzzer = new FizzBuzzer();

        string result = fizzbuzzer.FizzBuzz(input);

        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(6, "Fizz")]
    [InlineData(9, "Fizz")]
    public void ConvertMutiplesOfThreeToFizz(int input, string expected)
    {
        var fizzbuzzer = new FizzBuzzer();

        string result = fizzbuzzer.FizzBuzz(input);

        result.Should().Be(expected);
    }
}

public class FizzBuzzer
{
    public string FizzBuzz(int input)
    {
        if (input % 3 == 0)
        {
            return "Fizz";
        } 
        return input.ToString();
    }
}



