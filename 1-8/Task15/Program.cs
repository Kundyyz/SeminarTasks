// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekends(int num)
{
    return num == 7 || num == 6;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool weekend = Weekends(number);
if (number<8 && number> 0)
Console.WriteLine(weekend?"Да":"Нет");
else Console.WriteLine("Ввод неверный! Введите число 1-7");




