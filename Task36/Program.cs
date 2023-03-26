// Задача 36
// Задайте одномерный массив, заполненный случайными числами. 
// Hайдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
Console.Write($"Сумма элементов массива ");
PrintArray(array);
int sumElemOdd = SumElemOdd(array);
Console.Write($" находящихся на нечетных позициях = {sumElemOdd}");

void FillArray(int[] arraySize)
{
    Random rnd = new Random();
    for (int i = 0; i < arraySize.Length; i++)
    {
        arraySize[i] = rnd.Next(-100, 100);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int SumElemOdd(int[] arr)
{
    int i = 1;
    int sum = 0;
    while (i < array.Length)
    {
        sum += array[i];
        i += 2;
    }
    return sum;
}
