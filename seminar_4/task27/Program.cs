/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int GetSum(int num)
{
    int result = 0;
    for (int i = 0; num >= 1; i++)
    {
        result = result +num % 10;
        num = num / 10;
    }
    return result;
}

Console.WriteLine("Введите число для которого вы хотите найти сумму цифр: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе -> {GetSum(number)}");