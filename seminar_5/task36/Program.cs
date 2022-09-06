/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];
int ElementSummary = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(-10, 10);
    if (i % 2 != 0)
        ElementSummary = ElementSummary + numbers[i];
}

Console.WriteLine($"Одномерный массив: {String.Join(" ", numbers)}");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях -> {ElementSummary}");