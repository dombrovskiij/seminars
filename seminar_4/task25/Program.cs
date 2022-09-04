/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetResult(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
    {
        result = result * A;
    }
    return result;
}

Console.WriteLine("Введите число (A), которое хотите вовзвести в степень: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень (B), в которую хотите возвести число:");
int B = int.Parse(Console.ReadLine());

Console.WriteLine($"Результат возведения -> {GetResult(A,B)}");