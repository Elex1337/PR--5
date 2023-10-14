using System;

public class CustomException : Exception
{
    public CustomException(string message)
    {

    }
}
public class ExmplCLass
{
    public void Method_1()
    {
        try
        {
            Console.WriteLine("Вызван метод 2 из метода 1");
            Method_2();
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Поймал кастом в 1 методе: {ex.Message}");
        }
    }
    public void Method_2()
    {
        try
        {
            Console.WriteLine("Генерируем кастом в Method_2");
            throw new CustomException("Это юзерское исключение");
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Поймал кастом в 2 методе {ex.Message}");
            throw;
        }
    }
}

public class Program
{
    public static void Main()
    {
        ExmplCLass example = new ExmplCLass();
        try
        {
            example.Method_1();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Поймал исключение в Main: {ex.Message}");

        }
    }
}