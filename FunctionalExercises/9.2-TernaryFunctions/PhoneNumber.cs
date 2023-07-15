namespace IMoreno.FunctionalExercises.TernaryFunctions;

public enum NumberType
{
    Home,
    Mobile
}

public record CountryCode(string code)
{
    public static implicit operator CountryCode(string code) => new(code);
    public static implicit operator string(CountryCode countryCode) => countryCode.code;
}

public class PhoneNumber
{
    readonly NumberType device;
    readonly CountryCode code;
    readonly int number;
    
    public PhoneNumber(NumberType device, CountryCode code, int number)
    {
        this.device = device;
        this.code = code;
        this.number = number;
    }
}