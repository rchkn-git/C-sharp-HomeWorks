/*
// Задача 64: **Выполнить с помощью рекурсии**.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write(PrintNumbersBack(M, 1));

string PrintNumbersBack(int start, int end)
{
    if(start==end) return start.ToString();
    return (start + " " + PrintNumbersBack(start - 1, end));
}
*/

/*
// Задача 66: **Выполнить с помощью рекурсии**.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Sum(M, N));

int Sum (int a, int b)
{
    if (a == b) return a;
    return(Sum(a + 1, b) + a);
}
*/

// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите первое число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(Foo(M, N));

int Foo(int a, int b)
{
    if (a == 0)
        return b + 1;
    else
        if ((a > 0) && (b == 0))
        return Foo(a - 1, 1);
    else if ((a > 0) && (b > 0))
        return Foo(a - 1, Foo(a, b - 1));
    else 
        return 0;
}