/*
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }

    Console.Write("]   ");
}

int[] Product(int[] arr)
{
    int newSize = arr.Length / 2;
    if (arr.Length % 2 == 1) newSize += 1;
    int[] arrayNew = new int[newSize];
    for (int i = 0; i < newSize; i++)
    {
        arrayNew[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = arr[arr.Length / 2];
    return arrayNew;
}

int[] array = CreateArray(9, -19, 15);
int[] productPairElem = Product(array);
PrintArray(array);
PrintArray(productPairElem);




