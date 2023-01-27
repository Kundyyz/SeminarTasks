/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = Sum(number);
Console.WriteLine($"{number} -> {sum}");

int Sum(int num)
{
    int result = 0;
    if (num < 0) num = num * -1;
    while (num > 0)
    {
        int lastDigit = num % 10;
        result = result + lastDigit;
        num = num / 10;
    }
    return result;
}