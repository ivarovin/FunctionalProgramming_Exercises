using static IMoreno.FunctionalExercises.Optional.OptionType;
using IMoreno.FunctionalExercises.Optional;
using FluentAssertions;

namespace IMoreno.FunctionalExercises.GetWorkPermit.Tests
{
    public class GetWorkPermitTests
    {
        [Fact]
        public void Get_work_permit_of_employee()
        {
            var sut = new Afdafsadfsa();
            var employees = new Dictionary<string, Employee>();
            var workPermit = new WorkPermit("1a", DateTime.Now);
            employees.Add("1", new Employee("1", workPermit, DateTime.Now, DateTime.Now));

            sut.GetWorkPermit(employees, "1")
                .Match(() => default, result => result)
                .Should()
                .Be(workPermit);
        }

        [Fact]
        public void Work_permit_is_none_when_expired()
        {
            var sut = Afdafsadfsa.ForDay(DateTime.Today);
            var employees = new Dictionary<string, Employee>();
            var workPermit = new WorkPermit("1a", DateTime.Today.AddDays(-1));
            employees.Add("1", new Employee("1", workPermit, DateTime.Now, DateTime.Now));

            sut.GetWorkPermit(employees, "1")
                .Match(() => false, result => true)
                .Should()
                .BeFalse();
        }
    }
}