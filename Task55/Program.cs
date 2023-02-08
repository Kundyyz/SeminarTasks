// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

// Функция замены строк на столбцы
int[,] TurnMatrix(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}

//Тело программы
int[,] array2d = CreateMatrixRndInt(5, 6, 10, 100);
PrintMatrix(array2d);
Console.WriteLine();
if (array2d.GetLength(0) != array2d.GetLength(1))
{
    Console.WriteLine("Невозможно заменить строки на столбцы.");
}
else
{
    int[,] turnedArray2d = TurnMatrix(array2d);
    PrintMatrix(turnedArray2d);
}


// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

// int[,] GenerateMatrix(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// string PrintMatrix(int[,] matrix)
// {
//     string str = string.Empty;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         str += "[";
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j == matrix.GetLength(1) - 1) str += $" {matrix[i, j],3} ";
//             else str += $" {matrix[i, j],3}, ";
//         }
//         str += "]\n";
//     }
//     return str;

// }

// // int[,] ChangeRowsOnColumns(int[,] matrix)
// // {
// //     int[,] temporaryMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < matrix.GetLength(1); j++)
// //         {
// //             temporaryMatrix[j, i] = matrix[i, j];
// //         }
// //     }
// //     return temporaryMatrix;
// // }

// void ChangeRowsOnColumns(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < matrix.GetLength(1); j++)
//         {
//             int temporary = matrix[i, j];
//             matrix[i, j] = matrix[j, i];
//             matrix[j, i] = temporary;
//         }
//     }
// }

// int[,] matrixNumbers = GenerateMatrix(4, 4, -10, 10);
// Console.WriteLine($"До перемены строк и колонок - \n{PrintMatrix(matrixNumbers)}");

// if (matrixNumbers.GetLength(0) != matrixNumbers.GetLength(1))
// {
//     Console.WriteLine($"Замена невозможна");
// }
// else
// {
//     // int[,] matrixChange = ChangeRowsOnColumns(matrixNumbers);
//     // Console.WriteLine($"После перемены строк и колонок - \n{PrintMatrix(matrixChange)}");
//     ChangeRowsOnColumns(matrixNumbers);
//     Console.WriteLine($"После перемены строк и колонок - \n{PrintMatrix(matrixNumbers)}");
// }