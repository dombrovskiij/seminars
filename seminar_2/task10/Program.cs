// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int x = num / 10;
    int result = x % 10;
    Console.WriteLine($"Вторая цифра числа {num} -> {result}");
}
else
{
    Console.WriteLine("Введено не трёхзначное число, попробуйте еще раз");
}