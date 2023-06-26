using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.BindAndReturn;
using IMoreno.FunctionalExercises.LookUp;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.GetWorkPermit
{
    public class Afdafsadfsa
    {
        readonly Option<DateTime> today;
        public Afdafsadfsa() => today = None;
        Afdafsadfsa(DateTime today) => this.today = today;

        public Option<WorkPermit> GetWorkPermit(Dictionary<string, Employee> employees, string employeeId)
        {
            bool IsUpToDate(WorkPermit workPermit)
                => today.Match(() => true, (present) => workPermit.Expiry < present);

            return employees.LookUp(employeeId)
                            .Bind(e => e.WorkPermit)
                            .Where(IsUpToDate);
        }

        public double AverageYearsWorkedAtTheCompany(List<Employee> employees) { return 0; } // your implementation here...

        public static Afdafsadfsa ForDay(DateTime theDay) => new Afdafsadfsa(theDay);
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