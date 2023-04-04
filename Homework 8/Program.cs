


Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);


//Задача 54
/*int[,] array = GetArray(rows, columns, -9, 9);
PrintArray(array);
Console.WriteLine();
PrintArray(GetSortedArray(array));

int[,] GetSortedArray(int[,] arr)
{
    int[,] SortedArray = new int[arr.GetLength(0), arr.GetLength(1)];
    int[] row = new int[arr.GetLength(1)];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            row[j] = arr[i, j];
        }
        Sort(row);
         for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = row[j];
        }
    }
    return arr;
}

//Свапаем переменные
void swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

//Начинаем бегать по сортируемуму массиву методом "коктейльной" сортировки
int[] Sort(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;
    while(left < right)
    {
        for(int i = left; i < right; i++)
        {
            if(arr[i] < arr[i + 1])
            {
                swap(arr, i, i+1);
            }
        }
        right--;
        for(int i = right; i > left; i--)
        {
            if(arr[i] > arr[i-1])
            {
                swap(arr, i-1, i);
            }
            
        }
        left++;
    }
    return arr;
}
*/
/*
//Задача 58
Console.Write("Введите количество строк первой матрицы: ");
int rowsA = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов первой матрицы: ");
int columnsA = int.Parse(Console.ReadLine()!);


Console.Write("Введите количество строк второй матрицы: ");
int rowsB = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов второй матрицы: ");
int columnsB = int.Parse(Console.ReadLine()!);

int[,] arrayA = GetArray(rowsA, columnsA, -9, 9);
int[,] arrayB = GetArray(rowsB, columnsB, -9, 9);

PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(CompositionArr(arrayA, arrayB));
*/

// Получаем массив, заполненный рандомными числами, используется для всех задач
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

//Печать массива
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

/*
//Создаём результирующий массив
int[,] CompositionArr(int[,] arrA, int[,] arrB)
{
    int[,] ComposArr = new int [arrA.GetLength(0), arrB.GetLength(1)];
    if(arrA.GetLength(1) == arrB.GetLength(0))
    {
        for(int i = 0; i < ComposArr.GetLength(0); i++)
        {
            for(int j = 0; j < ComposArr.GetLength(1); j++)
            {
                ComposArr[i, j] = getComposition(arrayA, arrayB, i, j);
            }
        }
    }
    return ComposArr;
}

//Считаем произведения для результирующего массива
int getComposition(int[,] arrA, int[,] arrB, int i, int j)
{
    int res = 0;
    for(int k = 0; k < arrA.GetLength(1); k++)
    {
        res = res + arrA[i, k] * arrB[k, j];
    }
    return res;
}
*/

//