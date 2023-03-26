// Задача 38
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArrayRandomNumbers(array);
Console.Write("Mассив: ");
PrintArrayDouble(array);
double searchMax = SearchMax(array);
double searchMin = SearchMin(array);
double result = Math.Round((searchMax - searchMin), 1);

Console.WriteLine($"состоит из {array.Length} чисел. Максимальный элемент = {searchMax}, минимальный элемент = {searchMin}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {result}");

void FillArrayRandomNumbers(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double SearchMax(double[] arr)
{
    int i = 1;
    double max = arr[0];
    while (i < arr.Length)
    {
        if (arr[i] > max) max = arr[i];
        i++;
    }
    return max;
}

double SearchMin(double[] arr)
{
    int i = 1;
    double min = arr[0];
    while (i < arr.Length)
    {
        if (arr[i] < min) min = arr[i];
        i++;
    }
    return min;
}
