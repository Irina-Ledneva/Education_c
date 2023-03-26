// Задача 35
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат вотрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

Console.Write("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];


FillArray(array);
int amountOfElements = AmountOfElements(array);
PrintArray(array);
Console.Write($"{amountOfElements}");

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void FillArray(int[] arraySize)
{
    Random rnd = new Random();
    for (int i = 0; i < arraySize.Length; i++)
    {
        arraySize[i] = rnd.Next(0, 124);
    }
}

int AmountOfElements(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 10 && arr[i] <= 99)
        {
            count++;
        }

    }
    return count;
}

