// Задача 50
// Напишите программу, которая 
// на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


Console.Write("Задайте индекс строки: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте индекс столбца: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array2D = CreatMatrixRndInt(3, 4, 1, 100);
PrintMatrix(array2D);
Console.WriteLine();

if (numberA < array2D.GetLength(0) && numberB < array2D.GetLength(1))
{
    Console.WriteLine($"{array2D[(numberA), (numberB)]}");
}
else
{
    Console.WriteLine("Такого элемента нет.");
}


int[,] CreatMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine("|");
    }

}
