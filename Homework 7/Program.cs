/*
//Задача 47
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetDoubleArray(rows,columns, 0, 10);
PrintArray(array);

double[,] GetDoubleArray(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m,n];

    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            res[i, j] = Math.Round(new Random().Next(minValue, maxValue + 1) * new Random().NextDouble(), 1);
        }
    }
    return res;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
*/


//Задача 50
/*
int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
Console.Write("Введите строку: ");
int checkRows = int.Parse(Console.ReadLine()!);
Console.Write("Введите столбец: ");
int checkColumns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
Console.Write(checkLen(array, checkRows, checkColumns));
Console.WriteLine();
PrintArray(array);
*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}
/*
string checkLen(int[,] arr, int m, int n)
{
    string res;

    if(arr.GetLength(0) > m && arr.GetLength(1) > n && m >=0 && n >= 0)
    {
        res = "Такой элемент есть: " + checkArr(array, checkRows, checkColumns);
    }
    else
    {
        res = "Такого элемента в массиве нет!";
    }
    return res;
}

int checkArr(int[,] arr, int m, int n)
{
    return (arr[m, n]);
}
*/

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Задача 52
int rows = new Random().Next(1, 10);
int columns = new Random().Next(1, 10);
int[,] array = GetArray(rows, columns, 0, 10);
Console.Write($"[{String.Join(", ", GetAverage(array))}]");
PrintArray(array);

double[] GetAverage(int[,] arr)
{
    double[] Average = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        Average[i] = Math.Round(sum / arr.GetLength(1), 1);
    }
    return Average;
}