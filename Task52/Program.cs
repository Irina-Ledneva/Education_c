// Задача 52
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите количество строк в массиве: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int colMatrix = Convert.ToInt32(Console.ReadLine());

int[,] matrixNew = CreateMatrixRndInt(rowMatrix, colMatrix, 1, 10);
Console.WriteLine();
Console.WriteLine("Задан массив: ");
PrintMatrix(matrixNew);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
double[] array = AverageOfColumn(matrixNew);
PrintArray(array);

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

double[] AverageOfColumn(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average[i] += matrix[j, i];
        }
        average[i] = Math.Round(average[i] / matrix.GetLength(0), 1);
    }
    return average;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{i + 1} столбец: {arr[i]}; ");
        else Console.Write($"{i + 1} столбец: {arr[i]}; ");
    }
    Console.WriteLine("]");
}
