// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool turn = Turn(number);
Console.WriteLine(turn ? "да" : "нет");

bool Turn(int num)
{
    int newNumber = 0;
    int oldNumber = num;
    while (num > 0)
    {
        int lastDigit = num % 10;
        num = num / 10;
        newNumber = newNumber * 10 + lastDigit;
    }
    return newNumber == oldNumber;
}