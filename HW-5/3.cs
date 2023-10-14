using System;

class Calculator
{
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0)
        {
            throw new DivideByZeroException("Деление на ноль недопустимо.");
        }
        return dividend / divisor;
    }
}

class MathOperations
{
    public void PerformDivision(int dividend, int divisor)
    {
        Calculator calculator = new Calculator();
        try
        {
            int result = calculator.Divide(dividend, divisor);
            Console.WriteLine($"Результат деления: {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Произошло исключение: {ex.Message}");
            throw; 
        }
    }
}

class Program
{
    static void Main()
    {
        MathOperations mathOps = new MathOperations();

        try
        {
            mathOps.PerformDivision(10, 0);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Произошло исключение в вызывающем методе: {ex.Message}");
        }
    }
}
