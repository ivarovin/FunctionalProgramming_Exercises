using FluentAssertions;
using IMoreno.FunctionalExercises.Optional;

namespace IMoreno.FunctionalExercises.EmailValidator.Tests
{
    public class EmailValidatorTests
    {
        [Fact]
        public void Attempt_invalid_email_creation_returns_none()
        {
            Email.Create("invalid").Should().BeOfType<None<Email>>();
        }

        [Fact]
        public void Create_valid_email()
        {
            Email.Create("test@").Should().BeOfType<Some<Email>>();
        }
    }
}