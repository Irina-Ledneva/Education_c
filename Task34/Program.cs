// Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

FillArray(array);
int numberOfEvenNumbers = NumberOfEvenNumbers(array);
PrintArray(array);

Console.WriteLine($" -> {numberOfEvenNumbers} ");

void FillArray(int[] arraySize)
{
    Random rnd = new Random();
    for (int i = 0; i < arraySize.Length; i++)
    {
        arraySize[i] = rnd.Next(1, 1000);
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}

int NumberOfEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}
