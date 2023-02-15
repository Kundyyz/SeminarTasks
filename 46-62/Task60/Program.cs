/*
*Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

int[,,] CreateMatrixRndInt(int plane, int rows, int columns, int min, int max)
{
    int[,,] matrix = new int[plane, rows, columns];
            for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i, j, k] = min;
                    min += 1;
                }

            }
        }
        return matrix;
}

void PrintMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine($"{i+1} плоскость: ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("|");
                Console.Write($"{matrix[i, j, k],2}| ({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Задайте диапазон чисел(минимальное и максимальное число):");
int minNum = Convert.ToInt32(Console.ReadLine());
int maxNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте размер матрицы (глубина, строки, столбцы):");
int z = Convert.ToInt32(Console.ReadLine());
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
if (maxNum - minNum > x*y*z)
{
int[,,] matrixA = CreateMatrixRndInt (z, x, y, minNum, maxNum);
PrintMatrix(matrixA);
}
else Console.WriteLine("Количество заполняемых значении меньше размера матрицы");