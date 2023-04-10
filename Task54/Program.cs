// Задача 54
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк в массиве: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int colMatrix = Convert.ToInt32(Console.ReadLine());

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 1, 10);
PrintMatrix(matrixNew);
OrderString(matrixNew);
PrintMatrix(matrixNew);

void OrderString(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix.GetLength(1) - 1; m++)
            {
                if (matrix[i, m] < matrix[i, m + 1])
                {
                    int temp = matrix[i, m + 1];
                    matrix[i, m + 1] = matrix[i, m];
                    matrix[i, m] = temp;
                }
            }
        }
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine("");
}
