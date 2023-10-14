using System;

class Program
{
    static void Main()
    {
        try
        {
            RequestToWebResource("http://www.Noablelellelelel.com");
        }
        catch (WebResourceNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Завершение программы.");
        }
    }

    static void RequestToWebResource(string url)
    {
        if (!ResourceExists(url))
        {
            throw new WebResourceNotFoundException("Веб-ресурс не найден.");
        }

    }

    static bool ResourceExists(string url)
    {
        return false; 
    }
}

class WebResourceNotFoundException : Exception
{
    public WebResourceNotFoundException(string message) : base(message) { }
}
