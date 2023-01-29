// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Power(a, b);

void Power(int A, int B)
{
    int pow = A;
if (B<0) Console.WriteLine("B - ненатуральное число!");
else for (int i = 1; i < B; i++)
{
    pow *= A;
}
Console.WriteLine ($"{A}, {B} -> {pow}");
}
