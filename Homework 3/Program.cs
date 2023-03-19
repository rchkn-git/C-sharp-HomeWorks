string ReadStr(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}


//Задача 19

string a = ReadStr("Введите число: ");
int len = a.Length;

void CheckPoliandrom (string x)
{
    int b = 0;
    for(int i = 1; i <= len/2; i++)
    {
        if(Convert.ToInt32(a[i-1]) - Convert.ToInt32(a[len-i]) != 0)
        {
            b++;
        }
    }
    if(b > 0)
    {
        Console.WriteLine("Число не является палиндромом");
    }
    else
    {
        Console.WriteLine("Число является палиндромом");
    }
}
if(len != 5)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
    CheckPoliandrom(a);
}
/*
//Задача 23
int[] a = new int[3];
int[] b = new int[3];
a[0] = ReadInt("Введите координату X точки A: ");
a[1] = ReadInt("Введите координату Y точки A: ");
a[2] = ReadInt("Введите координату Z точки A: ");
b[0] = ReadInt("Введите координату X точки B: ");
b[1] = ReadInt("Введите координату Y точки B: ");
b[2] = ReadInt("Введите координату Z точки B: ");
double res = Math.Round(Math.Sqrt(Math.Pow(a[0]-b[0], 2) + Math.Pow(a[1]-b[1], 2) + Math.Pow(a[2]-b[2], 2)), 3);
System.Console.WriteLine("Расстояние между точками = " + res);



//Задание 23
int N = ReadInt("Введите число N: ");
for(int i = 1; i <= N; i++)
{
    int res = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write(res + " ");
}
*/