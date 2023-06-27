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
    }
}