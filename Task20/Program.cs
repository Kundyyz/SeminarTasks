// Задача 20: Напишите программу, которая
// 1 принимает на вход координаты двух точек и
// 2 находит расстояние между ними в 2D
// пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Напишите координаты двух точек");
Console.Write("Первая точка X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {distanceRound}");

double Distance(int a1, int b1, int a2, int b2)
{
    return Math.Sqrt(Math.Pow((a1 - a2), 2) + Math.Pow((b1 - b2), 2));
}

