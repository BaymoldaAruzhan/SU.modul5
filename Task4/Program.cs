//Генерация исключения в вызываемом методе и его обработка в вызывающем методе:
using System;
class Program
{
    static void Main()
    {
        try
        {
            // Вызов метода, который генерирует исключение.
            GenerateException();
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Произошла пользовательская ошибка: " + ex.Message);
        }
    }

    static void GenerateException()
    {
        // Генерация пользовательского исключения и его "поднятие" в вызывающий метод.
        throw new CustomException("Это пользовательское исключение.");
    }
}

class CustomException : Exception
{
    public CustomException(string message) : base(message)
    {
    }
}
