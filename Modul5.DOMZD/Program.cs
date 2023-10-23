//Перехват исключения запроса к несуществующему веб ресурсу:
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Попытка выполнить запрос к несуществующему веб-ресурсу.
            // Здесь может возникнуть исключение, например, System.Net.WebException.
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Завершение программы.");
        }
    }
}
