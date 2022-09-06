/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];
int count = 0;
for (int i = 0; i < size; i++)
{
    numbers[i] = new Random().Next(99, 1000);
    Console.Write(numbers[i] + " ");
}
for (int even = 0; even < numbers.Length; even++)
{
    if (numbers[even] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве -> {count}");