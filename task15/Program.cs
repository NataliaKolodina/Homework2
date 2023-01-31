// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите число, обозначающее день недели: ");
int num = int.Parse(Console.ReadLine());


if ((num > 0) & (num < 8))
{
      if ((num == 6) || (num == 7))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{num} -> да");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{num} -> нет");
        Console.ResetColor();
    }
}
else
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.WriteLine($"{num} -> не является днем недели");
    Console.ResetColor(); 
}


