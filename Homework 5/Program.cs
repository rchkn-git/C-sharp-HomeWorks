//генерируем рандомный массив
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}



/*
//Задача 1
int CheckChetn(int[] arr)
{
    int res = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] % 2) == 0 && arr[i] != 0) res++;
        Console.WriteLine (arr[i] + " " + res);
    }
    return res; 
}

int[] array = GetRandomArray(10, 0, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(CheckChetn(array));
*/

/*
//Зачада 2
int ArrayIndexCheck(int[] arr)
{
    int elemSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            elemSum = elemSum + arr[i];
        }
    }
    return elemSum;
}

int[] array = GetRandomArray(4, -100, 100);
Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine(ArrayIndexCheck(array));
*/

double[] GetRandomDoubleArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    double[] resDouble = new double[size];
    double[] resultR = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
        resDouble[i] = new Random().NextDouble();
        resultR[i] = Math.Round((result[i] + resDouble[i]), 2);
    }

    return resultR;
}

double findResBehindMinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    double res;
    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
    }
    res = max - min;
    return res;
}

double[] array = GetRandomDoubleArray(4, -100, 100);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine(findResBehindMinMax(array));