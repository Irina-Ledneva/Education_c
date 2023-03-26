// Задача 43 
// Напишите программу, которая.
// найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());


double X = 0;
double searchX = SearchX(X);

double Y = 0;
double searchY = SearchY(Y);


Console.WriteLine($"Две прямые пересекутся в точке с координатами Х: {searchX}, Y: {searchY})");


double SearchX(double x)
{
    x = Math.Round((b2 - b1) / (k1 - k2), 1);
    return x;
}

double SearchY(double y1)
{
    y1 = Math.Round((k1 * searchX + b1), 1);
    return y1;
}
