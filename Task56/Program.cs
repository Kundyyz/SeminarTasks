/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j],3} | ");
        }
        Console.WriteLine();
    }

}

int[] SumOfRows(int[,] matrix)
{
    int[] sumRows = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumRows[i] = sum;
    }
    return sumRows;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length) Console.WriteLine($"{i} строки: {arr[i]};");
    }
}

int MinSumOfRows(int[] array)
{
    int minElem = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
        {
            minElem = array[i];
            index = i;
        }
    }
    return index;
}

int rowLength = 3;
int columnLength = 3;
if (rowLength == columnLength)
{
    int[,] array2d = CreateMatrixRndInt(rowLength, columnLength, 1, 10);
    PrintMatrix(array2d);
    Console.WriteLine();
    Console.WriteLine("Сумма элементов:");
    int[] sumRowsArray = SumOfRows(array2d);
    PrintArray(sumRowsArray);
    Console.WriteLine();
    int minSumRowsIndex = MinSumOfRows(sumRowsArray);
    Console.WriteLine($"Hомер строки с наименьшей суммой элементов: {minSumRowsIndex} строка");
    Console.WriteLine();
}
else Console.WriteLine("Двумерный массив не прямоугольный");