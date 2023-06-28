using static IMoreno.FunctionalExercises.Optional.OptionType;
using static System.DateTime;
using IMoreno.FunctionalExercises.GetWorkPermit;
using FluentAssertions;

namespace IMoreno.FunctionalExercises.AverageYearsWorked.Tests
{
    public class AverageYearsWorkedAtCompanyTests
    {
        [Fact]
        public void Get_average_years_worked_at_company_with_one_employee()
        {
            var yesterday = Today.AddDays(-1);
            var employee = new Employee("MyId", None, yesterday, LeftOn: Today);

            CompanyReport.ForDay(Today)
                         .AverageYearsWorkedAtTheCompany(new List<Employee>() { employee })
                         .Should()
                         .Be(1);
        }

        [Fact]
        public void Get_only_exemployees_years_worked_at_company()
        {
            var yesterday = Today.AddDays(-1);
            var tomorrow = Today.AddDays(1);
            var exemployee = new Employee("MyId", None, JoinedOn: yesterday, LeftOn: tomorrow);
            var employee = new Employee("MyId", None, JoinedOn: yesterday, LeftOn: None);

            CompanyReport.ForDay(Today)
                         .AverageYearsWorkedAtTheCompany(new List<Employee>() { exemployee, employee })
                         .Should()
                         .Be(2);
        }
    }
}