// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа:");
int num_A = int.Parse(Console.ReadLine());
int num_B = int.Parse(Console.ReadLine()); 
int num_C = int.Parse(Console.ReadLine());

int max = num_A;

if (num_B > max)
{
    max = num_B;
}

if (num_C > max)
{
    max = num_C;
}

Console.WriteLine($"Наибольшее из введённых чисел: {max}");