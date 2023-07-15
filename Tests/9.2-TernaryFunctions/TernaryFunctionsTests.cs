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

    [Fact]
    public void Create_phone_number_from_country()
    {
        var ukNumber = new CountryCode("uk").CreatePhoneTemplate();

        ukNumber(NumberType.Home, 123456)
            .Country.Should().Be((CountryCode)"uk");
    }

    [Fact]
    public void Create_phone_number_from_country_and_type()
    {
        var ukHomeNumber = new CountryCode("uk").CreatePhoneTemplate(NumberType.Home);

        ukHomeNumber(123456).Type.Should().Be(NumberType.Home);
    }
}