using IMoreno.FunctionalExercises.PartialApplication;

namespace IMoreno.FunctionalExercises.TernaryFunctions;

public static class PhoneNumberExtensions
{
    public static Func<NumberType, int, PhoneNumber> CreatePhoneTemplate(this CountryCode code) =>
        PhoneNumber.Create.Apply(code);
    
    public static Func<int, PhoneNumber> CreatePhoneTemplate(this CountryCode code, NumberType type) =>
        number => PhoneNumber.Create(code, type, number);
}