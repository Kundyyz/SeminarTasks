/*
Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8

*/

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Введено ненатуральное число!");
}
else
{
    int count = 1;
    if (count % 2 == 1)
    count++;
    while (count < number)
        if (count % 2 == 0)
        {
            Console.Write($"{count}");
            count++;
        }

        else
        {
            Console.Write(", ");
            count++;
        }
    if (count == number)
        if (count % 2 == 0)
        {
            Console.WriteLine($"{count}");
        }
        else
        {
            Console.WriteLine("");

        }

}