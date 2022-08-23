// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число для сравнения: ");
int num_A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число для сравнения: ");
int num_B = int.Parse(Console.ReadLine());
if (num_A > num_B)
{
    Console.WriteLine($"Первое число {num_A} больше второго числа {num_B}");
}
else 
{
    Console.WriteLine($"Второе число {num_B} больше первого числа {num_A}");
}

