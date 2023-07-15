namespace IMoreno.FunctionalExercises.TernaryFunctions;

public record CountryCode(string code)
{
    public static implicit operator CountryCode(string code) => new(code);
    public static implicit operator string(CountryCode countryCode) => countryCode.code;
}