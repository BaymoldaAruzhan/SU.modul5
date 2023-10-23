//Обращение к элементам массива и выход за его пределы:
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };

        try
        {
            // Попытка обратиться к элементу, выходящему за пределы массива.
            int value = arr[5];
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Завершение обработки массива.");
        }
    }
}
