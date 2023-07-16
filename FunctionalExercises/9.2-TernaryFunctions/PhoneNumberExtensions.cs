using IMoreno.FunctionalExercises.PartialApplication;

namespace IMoreno.FunctionalExercises.TernaryFunctions;

public static class PhoneNumberExtensions
{
    public static Func<NumberType, int, PhoneNumber> CreatePhoneTemplate(this CountryCode code) =>
        PhoneNumber.Create.Apply(code);
    
    public static Func<int, PhoneNumber> WithType(this Func<NumberType, int, PhoneNumber> f, NumberType type) =>
        number => f(type, number);
}