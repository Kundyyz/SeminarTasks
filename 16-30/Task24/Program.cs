// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum (number);
if (number > 0)
Console.WriteLine($"Сумма чисел: {sum}");
else Console.WriteLine("Некорректное число");

int Sum (int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = result + i;
    }
    return result;
}