// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num <= 5)
{
    Console.WriteLine($"День {num} -> Нет, день рабочий");
}
else
{
    if (num > 5 && num <= 7)
    {
        Console.WriteLine($"День {num} -> Да, день выходной");
    }
    else if (num > 7)
    {
        Console.WriteLine($"День {num} -> Такого дня недели не существует");
    }
}