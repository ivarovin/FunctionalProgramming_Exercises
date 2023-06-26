using IMoreno.FunctionalExercises.BindAndReturn;
using IMoreno.FunctionalExercises.LookUp;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.GetWorkPermit
{
    public class Afdafsadfsa
    {
        public Option<WorkPermit> GetWorkPermit(Dictionary<string, Employee> employees, string employeeId)
        {
            return employees.LookUp(employeeId).Bind(e => e.WorkPermit);
        }

        public double AverageYearsWorkedAtTheCompany(List<Employee> employees) { return 0; } // your implementation here...
    }

    public record Employee
    (
        string Id,
        Option<WorkPermit> WorkPermit,
        DateTime JoinedOn,
        Option<DateTime> LeftOn
    );

    public record WorkPermit
    (
        string Number,
        DateTime Expiry
    );
}