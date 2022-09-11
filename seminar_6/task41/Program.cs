/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int NumbersMoreZero(int Num)
{
    int count = 0;
    for (int i = 0; i < Num; i++)
    {
        Console.WriteLine($"Введите число {i + 1}: ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0)
            count++;
    }
    Console.WriteLine();
    return count;
}

Console.WriteLine("Введите количество чисел (M): ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Чисел больше нуля (0) -> {NumbersMoreZero(a)}");
