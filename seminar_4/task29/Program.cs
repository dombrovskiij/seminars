/* Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
5, 0, 20 -> [1, 2, 5, 7, 19]
3, 1, 35 -> [6, 1, 33] */

int[] InitArray()
{
    int[] arr = new int[numN];
    for (int i = 0; i < numN; i++)
    {
        arr[i] = new Random().Next(numa, numb + 1);
    }
    return arr;
}
Console.WriteLine("Введите число (N), равное числу элементов массива: ");
int numN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число (a), равное наименьшему числу из массива: ");
int numa = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число (b), равное наибльшему числу измассива: ");
int numb = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(",", InitArray()));