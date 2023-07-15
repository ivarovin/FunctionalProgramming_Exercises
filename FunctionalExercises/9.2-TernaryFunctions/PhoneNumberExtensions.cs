using IMoreno.FunctionalExercises.PartialApplication;

namespace IMoreno.FunctionalExercises.TernaryFunctions;

public static class PhoneNumberExtensions
{
    public static Func<NumberType, int, PhoneNumber> CreatePhoneTemplate(this CountryCode code) =>
        PhoneNumber.Create.Apply(code);
}