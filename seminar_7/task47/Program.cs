/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] GetArray(int m, int n)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int k = 0; k < n; k++)
        {
            double s = new Random().NextDouble();
            result[i, k] = new Random().Next(-100, 100) * s;
        }
    }

    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            Console.Write($"{array[i, k]:f2}\t ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());

double[,] RandomArray = GetArray(m, n);
PrintArray(RandomArray);
