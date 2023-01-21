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
    if (count % 2 == 1) //чтобы не была запятая перед первым четным числом, если первое число от которого идет отчет - нечетное(как в нашем случае)
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
    if (count == number) //Это также для того чтобы в конце не была запятая
        if (count % 2 == 0)
        {
            Console.WriteLine($"{count}");
        }
        else
        {
            Console.WriteLine("");

        }

}