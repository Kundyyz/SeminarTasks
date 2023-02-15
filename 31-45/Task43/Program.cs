// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Задайте значение для k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение для b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

double y = GetY(k1, b1, k2, b2);
double x = GetX(y, k2, b2);
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}  ->  ({Math.Round(x, 1)}; {Math.Round(y, 1)})");

double GetY(double ka1, double ba1, double ka2, double ba2)
{
    double ya = (ka2 * ba1 - ka1 * ba2) / (ka2 - ka1);
    return ya;
}

double GetX(double ya, double ka2, double ba2)
{
    double xa = (ya - ba2) / ka2;
    return xa;
}