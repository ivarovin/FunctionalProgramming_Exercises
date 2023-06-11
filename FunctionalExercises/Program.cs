using IMoreno.FunctionalExercises;

Console.WriteLine("Hello, World!");
Console.WriteLine("Negate that 2 is even " + IsEven(2).Negated()());
Console.WriteLine("Negate that 1 is even " + IsEven(1).Negated()());

Func<bool> IsEven(int x) => () => x % 2 == 0;