/*
14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

bool Multiple(int num)
{
    return ((num % 7 ==0) && (num % 23 ==0));
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = Multiple(number);

if (result)
{
   Console.WriteLine("Да"); 
}
else Console.WriteLine("Нет");