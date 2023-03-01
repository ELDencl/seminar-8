// Задача 67: Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



int SumRec(int n)
{
    if (n == 0) return 0;
    else return n % 10 + SumRec(n / 10);


}





Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write(SumRec(n));