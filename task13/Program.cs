﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 12457333 -> 4

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write(num);

if (num > 99)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    int result = num % 10;
    Console.WriteLine($" -> {result}");
}
else
{
    Console.WriteLine($" -> третьей цифры нет");
}
