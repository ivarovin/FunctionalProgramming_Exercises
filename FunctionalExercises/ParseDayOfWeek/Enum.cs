using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.ParseDayOfWeek
{
    public static class Enum
    {
        public static Option<T> Parse<T>(string value) where T : struct
        {
            if (System.Enum.TryParse<T>(value, out var result))
                return result;
            else
                return new None<T>();
        }
    }
}