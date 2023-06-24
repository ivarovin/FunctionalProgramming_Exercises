using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.ParseDayOfWeek
{
    public static class Enum
    {
        public static Option<T> Parse<T>(string value) where T : struct
        {
            return System.Enum.Parse<T>(value);
        }
    }
}