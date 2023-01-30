// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int result = (num % 100 - num % 10) / 10;

if ((num > 99) & (num < 1000))
{
    Console.WriteLine($"{num} -> {result}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Число {num} не является трехзначным!");
    Console.ResetColor();
}