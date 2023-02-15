/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите натуральные числа:");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM<numberN)
{
int sumNumbers = SumOfNumbers(numberM, numberN);
Console.WriteLine(sumNumbers);
}
else
{
int sumNumbers = SumOfNumbers(numberN, numberM);
Console.WriteLine(sumNumbers);
}


int SumOfNumbers(int num1, int num2)
{
    if (num2 == num1-1) return 0;
    return num2 + SumOfNumbers(num1, num2 - 1);
}