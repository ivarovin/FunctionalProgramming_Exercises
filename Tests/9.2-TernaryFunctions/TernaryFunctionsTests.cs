using FluentAssertions;

namespace IMoreno.FunctionalExercises.TernaryFunctions.Tests;

public class TernaryFunctionsTests
{
    [Fact]
    public void Create_phone_number()
    {
        var phoneNumber = PhoneNumber.Create("uk", NumberType.Home, 123456);

        phoneNumber.Country.Should().Be((CountryCode)"uk");
        phoneNumber.Type.Should().Be(NumberType.Home);
        phoneNumber.Number.Should().Be(123456);
    }
}