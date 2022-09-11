/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
void dot(double a, double b, double c, double d)
{
    double x = 0;
    double y = 0;
    x = (c - a) / (b - d);
    y = b * x + a;
    Console.WriteLine($"({x}, {y})");
}

Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"(Точка пересечения двух прямых, заданных уравнение вида y = k1 * x + b1, y = k2 * x + b2; с задаными значениями равна ->"); dot(b1, k1, b2, k2);