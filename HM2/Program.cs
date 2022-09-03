// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int c = int.Parse(Console.ReadLine());
if (a > b)
    if (a > c)
    {
        Console.WriteLine("max=a");
    }
if (b > a)
    if (b > c)
    {
        Console.WriteLine("max=b");
    }
    else
        Console.WriteLine("max=c");
