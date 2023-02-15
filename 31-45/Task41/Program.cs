// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите длину массива");
int m = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(m);
PrintArray(arr);
int countPositiveElements = PositiveElem (arr);
Console.WriteLine(countPositiveElements);

int[] CreateArray(int size)
{
    int[] array = new int[size];
Console.WriteLine("Введите элементы массива");
        for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ->  ");
    }
}

int PositiveElem (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;        
    }
    return count;
}