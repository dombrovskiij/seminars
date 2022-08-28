//Задача 13: Напишите программу, которая выводит третью цифру (справа налево) заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());


if (num < 100)
 {
    Console.WriteLine("Третьей цифры нет, введите другое число");
 }
else
{
   if (num < 1000)
 { 
    int result = num / 100;
    Console.WriteLine($"Третье число {num} -> {result}");
 }
else if (num >= 1000)
{
    int num2 = num / 100;
    int result = num2 % 10;
    Console.WriteLine($"Третье число {num} -> {result}");
}
 }
