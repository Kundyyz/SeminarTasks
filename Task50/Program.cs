// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.WriteLine($"{matrix[i, j],4}  |");
        }
    }
}

bool Range (int[,] matrix, int indexRow, int indexColumn)
{
      return (indexRow < matrix.GetLength(0) && indexColumn < matrix.GetLength(1));
}

Console.WriteLine("Введите искомый индекс(строка):");
int searchIndexRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомый индекс(столбец):");
int searchIndexColumn = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine(Range(array2D, searchIndexRow, searchIndexColumn) 
                   ? (array2D [searchIndexRow,searchIndexColumn]) 
                   : "такого элемента в массиве нет");

