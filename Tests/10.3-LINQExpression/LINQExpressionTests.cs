using IMoreno.FunctionalExercises.ApplyEverything;
using IMoreno.FunctionalExercises.ToOption;

namespace IMoreno.FunctionalExercises.LINQExpression.Tests;

public class LINQExpressionTests
{
    struct Reason
    {
    }

    struct Ingredients
    {
    }

    struct Food
    {
    }

    [Fact]
    public void Delicious_dish()
    {
        Either<Reason, Unit> WakeUpEarly() => new Unit();
        Either<Reason, Ingredients> ShopForIngredients() => new Ingredients();
        Either<Reason, Food> Cook(Ingredients ingredients) => new Food();

        var result = from _ in WakeUpEarly()
            from ingredients in ShopForIngredients()
            from food in Cook(ingredients)
            select food;

        result.Match
        (
            _ => Assert.True(false),
            food => Assert.True(true)
        );
    }
}