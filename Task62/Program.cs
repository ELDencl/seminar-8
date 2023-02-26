// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GetSpiralArray(int N)
{
    int[,] result = new int[N, N];
    int num = 1;
    for (int shift = 0; shift < N - 2; shift++)
    {
        for (int i = 0 + shift; i < N - shift; i++)
        {
            result[0 + shift, i] = num;
            num++;
        }
        num--;
        for (int i = 0 + shift; i < N - shift; i++)
        {
            result[i, N - 1 - shift] = num;
            num++;
        }
        num--;
        for (int i = N - 1 - shift; i >= 0 + shift; i--)
        {
            result[N - 1 - shift, i] = num;
            num++;
        }
        num--;
        for (int i = N - 1 - shift; i >= 1 + shift; i--)
        {
            result[i, 0 + shift] = num;
            num++;
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

Console.Clear();
int[,] array = GetSpiralArray(4);
PrintArray(array);