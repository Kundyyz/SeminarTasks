// Задача 18: Напишите программу, которая по
// 1 заданному номеру четверти, 
// 2 показывает диапазон возможных координат точек в этой четверти (x и y).

string Quarter(string? num)
{
    if (num == "1") return "xc > 0 и yc > 0";
    if (num == "2") return "xc < 0 и yc > 0";
    if (num == "3") return "xc < 0 и yc < 0";
    if (num == "4") return "xc > 0 и yc < 0";
    return "Введен некорректный номер";
}

Console.WriteLine("Введите номер четверти");
string? number = Console.ReadLine();

string coordinate = Quarter(number);

Console.WriteLine(coordinate);



    