/*
*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/



int[,] CreateSpiralMatrix(int rows, int columns) //либо можно везде одно значение n, так как метод работает для квадрата
{
    int[,] matrix = new int[rows, columns];
    int elem = 1;
    for (int i = 0; i < rows / 2 + 1; i++)
    {
        for (int j = i; j < columns - i; j++) matrix[i, j] = elem++;
        for (int k = i + 1; k < rows - i; k++) matrix[k, columns - 1 - i] = elem++;
        for (int l = columns - i - 2; l >= i; l--) matrix[rows - 1 - i, l] = elem++;
        for (int m = rows - i - 2; m > i; m--) matrix[m, i] = elem++;
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

Console.WriteLine("Задайте размер квадратной матрицы:");
int rowLength = Convert.ToInt32(Console.ReadLine());
int columnLength = Convert.ToInt32(Console.ReadLine());
if (rowLength < 0 || columnLength < 0) Console.WriteLine("Введите натуральное число");
else if (rowLength != columnLength) Console.WriteLine("Матрица не квадратная");
else
{
    int[,] spiralMatrix = CreateSpiralMatrix(rowLength, columnLength);
    PrintMatrix(spiralMatrix);
}
