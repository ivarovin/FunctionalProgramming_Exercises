using static System.DateTime;
using IMoreno.FunctionalExercises.Optional;
using FluentAssertions;

namespace IMoreno.FunctionalExercises.GetWorkPermit.Tests
{
    public class GetWorkPermitTests
    {
        WorkPermit WorkPermit => new WorkPermit("1a", Today);
        Dictionary<string, Employee> Employees => new()
        {
            { "MyId", new Employee("1", WorkPermit, Today, Today) }
        };

        [Fact]
        public void Get_work_permit_of_employee()
        {
            new CompanyReport()
                .GetWorkPermit(Employees, "MyId")
                .Match(() => default, result => result)
                .Should()
                .Be(WorkPermit);
        }

        [Fact]
        public void Work_permit_is_none_when_expired()
        {
            CompanyReport.ForDay(Today)
                         .GetWorkPermit(Employees, "MyId")
                         .Match(() => false, result => true)
                         .Should()
                         .BeFalse();
        }

        [Fact]
        public void Work_permit_is_not_expired_if_date_is_over_today()
        {
            var yesterday = Today.AddDays(-1);

            CompanyReport.ForDay(yesterday)
                         .GetWorkPermit(Employees, "MyId")
                         .Match(() => false, result => true)
                         .Should()
                         .BeTrue();
        }
    }
}