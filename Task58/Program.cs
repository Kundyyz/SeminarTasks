/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiplicationMatrix(int[,] mtxA, int[,] mtxB)
{
    int[,] matrix = new int[mtxA.GetLength(0), mtxB.GetLength(1)];
    for (int i = 0; i < mtxA.GetLength(0); i++)
    {
        for (int j = 0; j < mtxB.GetLength(1); j++)
        {
            for (int k = 0; k < mtxA.GetLength(1); k++)
            {
                matrix[i, j] += mtxA[i, k] * mtxB[k, j];
            }
        }
    }
    return matrix;
}

Console.WriteLine("Задайте размер матрицы А:");
int rowLengthA = Convert.ToInt32(Console.ReadLine());
int columnLengthA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте размер матрицы B:");
int rowLengthB = Convert.ToInt32(Console.ReadLine());
int columnLengthB = Convert.ToInt32(Console.ReadLine());

if (columnLengthA == rowLengthB)
{
    Console.WriteLine("Матрица A:");
    int[,] matrixA = CreateMatrixRndInt(rowLengthA, columnLengthA, 1, 10);
    PrintMatrix(matrixA);
    Console.WriteLine("Матрица В:");
    int[,] matrixB = CreateMatrixRndInt(rowLengthB, columnLengthB, 1, 10);
    PrintMatrix(matrixB);
    Console.WriteLine("Матрица C = A * B:");
    int[,] matrixC = MultiplicationMatrix(matrixA, matrixB);
    PrintMatrix(matrixC);
}
else Console.WriteLine("Невозможно переумножить!");