// Console.Write("Введите числа через пробел: ");
// string[] array = Console.ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine("Результат равен = " + IsBiggerThanZero(array));

// int IsBiggerThanZero(string[] arr)
// {
//     int rez = 0;
//     for(int i = 0; i < arr.Length; i++)
//     {
//         if(int.Parse(arr[i]) > 0)
//         {
//             rez++;
//         }
//     }
//     return rez;
// }


double k1 = ReadDouble("Введите число k1: ");
double k2 = ReadDouble("Введите число k2: ");
double b1 = ReadDouble("Введите число b1: ");
double b2 = ReadDouble("Введите число b2: ");
if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Линии лежат друг на друге");
    }
else
{
    Console.WriteLine($" Пересечение прямых находится в координате: [{String.Join(", ", Cross(k1, k2, b1, b2))}]");
}

double[] Cross(double a, double b, double c, double d)
{
    double[] CrossArr = new double[2];
    CrossArr[0] = (c - d) / (-1 *(a - b));
    CrossArr[1] = b * CrossArr[0] + d;
    return  CrossArr;
}

double ReadDouble(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}
