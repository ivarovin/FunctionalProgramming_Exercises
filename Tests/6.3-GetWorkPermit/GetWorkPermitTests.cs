using IMoreno.FunctionalExercises.Optional;
using FluentAssertions;

namespace IMoreno.FunctionalExercises.GetWorkPermit.Tests
{
    public class GetWorkPermitTests
    {
        WorkPermit WorkPermit => new WorkPermit("1a", DateTime.Today);
        Dictionary<string, Employee> Employees => new()
        {
            { "MyId", new Employee("1", WorkPermit, DateTime.Today, DateTime.Today) }
        };

        [Fact]
        public void Get_work_permit_of_employee()
        {
            new Afdafsadfsa()
                .GetWorkPermit(Employees, "MyId")
                .Match(() => default, result => result)
                .Should()
                .Be(WorkPermit);
        }

        [Fact]
        public void Work_permit_is_none_when_expired()
        {
            Afdafsadfsa.ForDay(DateTime.Today)
                       .GetWorkPermit(Employees, "MyId")
                       .Match(() => false, result => true)
                       .Should()
                       .BeFalse();
        }
    }
}