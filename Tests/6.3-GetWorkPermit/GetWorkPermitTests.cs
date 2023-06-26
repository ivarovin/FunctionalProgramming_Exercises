using FluentAssertions;
using IMoreno.FunctionalExercises.Optional;

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
    }
}