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