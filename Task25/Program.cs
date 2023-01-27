// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Power();

void Power()
{
if (B<0) Console.WriteLine("B - ненатуральное число!");
else Console.WriteLine ($"{A}, {B} -> {Math.Pow(A, B)}");
}
