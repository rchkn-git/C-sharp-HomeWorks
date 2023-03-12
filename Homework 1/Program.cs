/* Задание 1
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.WriteLine("Первое число больше второго!");
}
else
{
    Console.WriteLine("Второе число больше первого!");
}
*/

/* Задание 2
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
    Console.WriteLine("Самое большое число из трёх: " + max);
}
else
{
    Console.WriteLine("Самое большое число из трёх: " + max);
}
*/

/* Задание 3
Console.WriteLine("Введите число для проверки на чётность: ");
int a = int.Parse(Console.ReadLine()!);
int res = a % 2;
if (res == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}
*/

/* Задание 4
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int mnozhitel = a / 2;
int rez = 0;
int i = 1;
while (i <= mnozhitel)
{
    rez = 2 * i;
    Console.Write(rez + " ");
    i++;
}
*/