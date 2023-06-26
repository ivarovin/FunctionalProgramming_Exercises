using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.GetWorkPermit
{
    public static class Afdafsadfsa
    {
        Option<WorkPermit> GetWorkPermit(Dictionary<string, Employee> employees, string employeeId) { }// your implementation here...
        double AverageYearsWorkedAtTheCompany(List<Employee> employees) { } // your implementation here...

        public record Employee
        (
            string Id,
            Option<WorkPermit> WorkPermit, DateTime JoinedOn,
            Option<DateTime> LeftOn
        );

        public record WorkPermit
        (
            string Number,
            DateTime Expiry
        );
    }
}