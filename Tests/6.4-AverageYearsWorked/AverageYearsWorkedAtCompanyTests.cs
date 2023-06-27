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
            var employee = new Employee("MyId", None, yesterday, Today);

            CompanyReport.ForDay(Today)
                         .AverageYearsWorkedAtTheCompany(new List<Employee>() { employee })
                         .Should()
                         .Be((yesterday - Today).TotalDays);
        }

        [Fact]
        public void Get_only_exemployees_years_worked_at_company()
        {
            var yesterday = Today.AddDays(-1);
            var tomorrow = Today.AddDays(1);
            var employee = new Employee("MyId", None, JoinedOn: yesterday, LeftOn: tomorrow);

            CompanyReport.ForDay(Today)
                         .AverageYearsWorkedAtTheCompany(new List<Employee>() { employee })
                         .Should()
                         .Be(0);
        }
    }
}