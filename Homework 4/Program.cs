int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int MyPow(int a, int b)
{
    int res = a;
    for(int i = 1; i < b; i++)
    {
        res = res * a;
    }
    return res;
}

//Задание 25
// int A = ReadInt("Введите число: ");
// int B = ReadInt("Введите степень, в которую хотите его возвести: ");
// Console.WriteLine("Число " + A + " в степени " + B + " = " + MyPow(A, B));

//Задание 27
// int A = ReadInt("Введите число: ");
// int SumNumbers(int a)
// {
//     int res = 0;
//     while(a != 0)
//     {
//         res = res + a % 10;
//         a = a / 10;
//     }
//     return res;
// }
// Console.WriteLine("Сумма цифр числа " + A + " = " + SumNumbers(A));

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
int[] array = GetRandomArray(8, -9, 9);
Console.WriteLine($"[{String.Join(",", array)}]");
