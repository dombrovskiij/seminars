/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


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

void FindAverage(int[,] array)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        double summary = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            summary += array[i, k];
        }
        Console.Write($"Среднее арифметическое столбца: {summary / array.GetLength(0)} ");
    }
}

int[,] RandomArray = GetArray(2, 5);
PrintArray(RandomArray);
Console.WriteLine();
FindAverage(RandomArray);