// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 12457333 -> 4

Console.Clear();

int num = new Random().Next();
int count = 10;
int result = (num % count * 10 - num % count) / count;
if (num > 99)
{
    while (num < count * 100)
    {
        Console.WriteLine($"{num} -> {result}");
    }
    count = count * 10;
}
else
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}