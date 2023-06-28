using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.BindAndReturn;
using IMoreno.FunctionalExercises.LookUp;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.GetWorkPermit
{
    public class CompanyReport
    {
        readonly Option<DateTime> today;
        public CompanyReport() => today = None;
        CompanyReport(DateTime today) => this.today = today;

        public Option<WorkPermit> GetWorkPermit(Dictionary<string, Employee> employees, string employeeId)
        {
            bool IsUpToDate(WorkPermit workPermit)
                => today.Match(() => true, (present) => workPermit.Expiry > present);

            return employees.LookUp(employeeId)
                            .Bind(e => e.WorkPermit)
                            .Where(IsUpToDate);
        }

        public double AverageYearsWorkedAtTheCompany(List<Employee> employees)
        {
            List<double> TimeAtCompany(Employee employee)
                => employee.LeftOn.Match
                (
                    () => new List<double> { 0 },
                    date => new List<double> { (date - employee.JoinedOn).TotalDays }
                );

            bool DidLeftCompany(Employee employee) => employee.LeftOn != None;

            return employees.Where(DidLeftCompany)
                            .Bind(TimeAtCompany)
                            .Sum();
        }

        public static CompanyReport ForDay(DateTime theDay) => new CompanyReport(theDay);
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