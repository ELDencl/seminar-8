// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка




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


int[] RowSum(int[,] array)
{
    int sum = 0;
    int[] sumRow = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumRow[i] = sum;
        sum = 0;

    }
    return sumRow;
}

int[] SortMinArray(int[] array)
{
    int temp;
    int[] minArray = array;
    for (int i = 0; i < minArray.Length - 1; i++)
    {
        for (int j = i + 1; j < minArray.Length; j++)
        {
            if (minArray[i] > minArray[j])
            {
                temp = minArray[i];
                minArray[i] = minArray[j];
                minArray[j] = temp;
            }
        }
    }
    return minArray;
}





void PrintRowMin(int[] sortArray, int[] array)
{
    int minNum = sortArray[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minNum == array[i])   // по какой то причине не выполняет проверку. Не могу понять в чем дело  ???
        {
            Console.WriteLine($"{i + 1} строка");
            break;
        }
    }
}




Console.Clear();
int[,] array2D = GetArray(5, 5, 0, 10);
PrintArray(array2D);

int[] max = RowSum(array2D);
Console.WriteLine($"Не отсортированный массив = {string.Join(", ", max)}");

int[] MinArray = SortMinArray(max);



Console.WriteLine($"Отсортированный массив = {string.Join(", ", MinArray)}");
PrintRowMin(MinArray, max);
