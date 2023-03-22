// Задача 25
// 1. Напишите цикл, который принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число возведенное в степень: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральную степень: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int degree = Degree(number1, number2);

if (number1 != 0 && number2 > 0)
{
    Console.WriteLine(degree);
}
else
{
    Console.WriteLine("Введено неверное значение!");
}
int Degree(int num1, int num2)
{
    int pow = 1;
    for (int i = 0; i < num2; i++)
    {
        checked
        {
            pow *= num1;
        }
    }
    return pow;
}

