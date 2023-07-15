namespace IMoreno.FunctionalExercises.TernaryFunctions;

public class PhoneNumber
{
    public CountryCode Country { get; }
    public NumberType Type { get; }
    public int Number { get; }

    public PhoneNumber(CountryCode country, NumberType type, int number)
    {
        this.Country = country;
        this.Type = type;
        this.Number = number;
    }
    
    public static Func<CountryCode, NumberType, int, PhoneNumber> Create => 
        (code, device, number) => new PhoneNumber(code, device, number);
}