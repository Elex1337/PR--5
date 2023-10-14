using System;

class OperationExecutor
{
    public void ExecuteOperations()
    {
        MathOperations mathOps = new MathOperations();
        try
        {
            mathOps.PerformOperation();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Произошло исключение: {ex.Message}");
        }
    }
}

class MathOperations
{
    public void PerformOperation()
    {
        try
        {
            throw new CustomException("Это пользовательское исключение.");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Произошло исключение: {ex.Message}");
            throw; 
        }
    }
}

class CustomException : Exception
{
    public CustomException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        OperationExecutor executor = new OperationExecutor();

        try
        {
            executor.ExecuteOperations();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Произошло исключение в вызывающем методе: {ex.Message}");
        }
    }
}
