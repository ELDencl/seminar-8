// Задача 65: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"



string NumbersRec(int m, int n)
{
    if (m == n) return $"{m}";
    else return $"{m}, " + NumbersRec(m + 1, n);
}



Console.Clear();
Console.WriteLine(NumbersRec(4, 8));