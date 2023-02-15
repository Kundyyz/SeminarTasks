// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

/*

int number = new Random().Next(100,1000);
Console.WriteLine($"Случайное трёхзначное число: {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int result = firstDigit*10 + thirdDigit;
Console.WriteLine($"{result}");
*/

int rendomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число: {rendomNumber}");
int finishNumber = GetNumber(rendomNumber);
Console.WriteLine($"Конечное число => {finishNumber}");

int GetNumber(int number)
{
int firstNumber = number / 100;
int secondNumber = number % 10;

int result = firstNumber * 10 + secondNumber;
return result;
}