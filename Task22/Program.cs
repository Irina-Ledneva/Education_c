// Задача 22
// Напишите программу, которая
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу квадратов чисел от 1 до N.


// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    Qater(n);
}
else
{
    Console.WriteLine("Введено недопустимое значение. ");
}

void Qater(int a)
{
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine($"{i,4} --- {i * i,4}");
    }
}