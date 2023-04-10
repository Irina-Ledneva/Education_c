// Задача 56
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = new int[4, 4];
FillMatrixRandom(array);
PrintMatrix(array);
Console.WriteLine();
MinSumElem(array);


void MinSumElem(int[,] matrix)
{
    int minElem = 0;
    int minSumElem = 0;
    int sumElem = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minElem += matrix[0, i];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sumElem += matrix[i, j];
        if (sumElem < minElem)
        {
            minElem = sumElem;
            minSumElem = i;
        }
        sumElem = 0;
    }
    Console.Write($"{minSumElem + 1} строка имеет наименьшую сумму элементов.");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
