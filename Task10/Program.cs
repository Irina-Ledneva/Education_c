// Задача 10
// Напишите программу, которая 
// 1.принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondNum = SecondNum(number);

if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра: {secondNum}");
}
else
{
    Console.WriteLine("Введенно недопустимое значение");
}
int SecondNum(int num)
{
    int num1 = num / 10;
    int num2 = num1 % 10;
    return num2;
}