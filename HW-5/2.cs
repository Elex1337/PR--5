using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        try
        {
            for (int i = 0; i <= arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Произошло исключение: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Завершение обработки массива.");
        }
    }
}
