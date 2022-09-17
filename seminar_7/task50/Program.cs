/* Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            result[i, k] = new Random().Next(-100, 100);
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]}\t ");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, k] == number)
            {
                Console.Write($"Число {number} встречается в элементе со следующими индексами: [{i}, {k}] ");
                return;
            }
        }
    }
    Console.Write($"{number} -> такого числа в массиве нет");
}

Console.WriteLine("Введите число (n): ");
int NumberToSearch = int.Parse(Console.ReadLine());

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);

int[,] RandomArray = GetArray(m, n);
PrintArray(RandomArray);

FindNumber(RandomArray, NumberToSearch);