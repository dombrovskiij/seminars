/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */
Console.WriteLine("Введите размер массива: ");
int numbers = int.Parse(Console.ReadLine());
double[] array = new double[numbers];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите элемент массива: ");
    double figure = Convert.ToDouble(Console.ReadLine());
    array[i] = figure;
}

Console.WriteLine('[' + string.Join(" ", array) + ']');

double maxnumber = array[0];
double minnumber = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > maxnumber)
    {
        maxnumber = array[i];
    }
    if (array[i] < minnumber)
    {
        minnumber = array[i];
    }
}
double difference = maxnumber - minnumber;
Console.Write($"Разница между максимальным и минимальным элементом -> {difference}");