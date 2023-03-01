






// Собрать строку с числами от а до b , a<=b

string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}


string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
    else return string.Empty;
}

Console.WriteLine(NumbersFor(1, 10));
Console.WriteLine(NumbersRec(1, 10));




// Сумма чисел от 1 до n



int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++)
    {
        result += i;
    }
    return result;
}



int SumRec(int n)
{
    if (n == 0)
    {
        return 0;
    }
    else
    {
        return n + SumRec(n - 1);
    }
}



Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));




// Факториал числа 

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }
    return result;
}


int FactorialRec(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        return n * FactorialRec(n - 1);
    }
}


Console.WriteLine(FactorialFor(5));
Console.WriteLine(FactorialRec(5));



// Вычислить a^n (a в степени n)



int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a;
    }
    return result;

}

int PowerRec(int a, int n)
{
    // return n == 0 ? 1 : PowerRec(a, n - 1) * a;   Решение задачи через тернарный оператор 
    if (n == 1)
    {
        return a;
    }
    else
    {
        return a * PowerRec(a, n - 1);
    }
}


Console.WriteLine(PowerFor(2, 3));
Console.WriteLine(PowerRec(2, 3));





// Просмотр папок
string path = "C:/Users/den00/OneDrive/Рабочий стол/seminar 8/Lection7/Recursion";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);



// игра в пирамидки 

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}


Towers();



// Обход дерева
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
// //                 0    1    2    3     4    5    6    7    8    9    10   11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos + 1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
