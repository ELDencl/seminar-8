// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GetArray(int row, int column, int minValue, int maxValue)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t ");
        }
        Console.WriteLine();
    }
}


int[,] ProductMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return result;
}








Console.Write("Введите колличество строк 1 массива: ");
int row1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов 1 массива: ");
int column1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество строк 2 массива: ");
int row2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите колличество столбцов 2 массива: ");
int column2 = int.Parse(Console.ReadLine()!);


int[,] array1 = GetArray(row1, column1, 0, 10);
int[,] array2 = GetArray(row2, column2, 0, 10);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();



if (array1.GetLength(1) == array2.GetLength(0))
{
    int[,] matrix3 = ProductMatrix(array1, array2);
    Console.WriteLine("Результирующая матрица");
    PrintArray(matrix3);
}
else Console.WriteLine("такие матрицы невозможно перемножить");
