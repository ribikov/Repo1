using System;

class Progran
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int year =
    int.Parse(Console.ReadLine());

        if (year % 4 == 0 && year % 100 != 0) || year % 400 == 0 )
        {
            Console.WriteLine("{0} год - високосный", year);
        }
        else
        {
            Console.WriteLine("{0} год - не високосный", year);
        }
    }
}