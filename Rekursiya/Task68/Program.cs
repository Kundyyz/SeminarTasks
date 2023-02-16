/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.WriteLine("Введите натуральные числа:");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

int functionAkerman = FunctionAk(numberM, numberN);
Console.WriteLine(functionAkerman);

int FunctionAk(int num1, int num2)
{
    if (num1 == 0) return num2+1;
    if (num2 == 0) 
    return FunctionAk(num1-1, 1);
    return FunctionAk(num1-1, FunctionAk(num1, num2 - 1));
}

