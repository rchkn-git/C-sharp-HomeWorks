int VvodDan() // Функция ввода, чтобы не вводить её по 30 раз
{
    Console.WriteLine("Введите число: ");
    int V = int.Parse(Console.ReadLine()!);
    return V;
}

int Check(int arg1)
{
    int resCheck = arg1 / 100;
    return resCheck;
}

/* Задача 10

int Sredn(int arg1)
{
    int res = arg1 / 10;
    res = res % 10;
    return res;
}

int a = VvodDan();
int check = Check(a);
if (check == 0 || check > 9)
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
else
{
    int result = Sredn(a);
    if (result < 0)
    {
        result = result * (-1);
    } 
Console.WriteLine(result);
}
*/


/* Задача 13




int a = VvodDan();
int Prov = Check(a);
if (Prov == 0)
{
    Console.WriteLine("В числе отсутствет третий символ");
}
else
{
    if (a < 0)
    {
        a *= -1;
    }
    while (a > 1000)
    {
        a = a / 10;
    }
    Console.WriteLine(a % 10);
}

*/

/* Задача 15

int a = VvodDan();
switch (a)
{
    case 1:
    Console.WriteLine("Будний");
    break;

    case 2:
    Console.WriteLine("Будний");
    break;

    case 3:
    Console.WriteLine("Будний");
    break;

    case 4:
    Console.WriteLine("Будний");
    break;
    
    case 5:
    Console.WriteLine("Будний");
    break;

    case 6:
    Console.WriteLine("Выходной");
    break;

    case 7:
    Console.WriteLine("Выходной");
    break;

    default:
    Console.WriteLine("В неделе нет такого дня!");
    break;
}
*/