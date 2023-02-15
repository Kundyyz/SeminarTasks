// Задача 10: Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit( int num)
{
    int result = num / 10 % 10;
    return result; 
}

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number / 100 > 0) && (number / 1000 == 0))
{
int secondDigit = SecondDigit(number);
Console.WriteLine($"{secondDigit}");
}
else Console.WriteLine("Введено не трехзначное число!");
