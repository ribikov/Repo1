﻿using System;

class Progran
{
    static void Main()
    {
        Console.BackgroundColor
            = ConsoleColor.Blue;
        Console.Write("Введите год: ");
        int year =
    int.Parse(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            Console.WriteLine("{0} год - високосный", year);
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("{0} год - не високосный", year);
            Console.ReadKey();
        }
    }
}