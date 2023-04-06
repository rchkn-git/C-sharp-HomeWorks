
/*
//Задача 54
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);



int[,] array = GetArray(rows, columns, -9, 9);
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
//Задача 57
int[,] array = GetArray(rows, columns, 0, 9);
int[] Vocabulary = new int[0];
Vocabulary = getVocabulary(array);
PrintArray(array);
Console.WriteLine();
int[,] VocabAndCount = new int[Vocabulary.Length, 2];
VocabAndCount = makeVocabAndCount(Vocabulary);


PrintVocabularyAndCount(countNumsInVocabulary(array, VocabAndCount));

// Пробегаемся по массиву для создания словаря
int[] getVocabulary(int[,] arr)
{
    int checkNumber = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            checkNumber++;
            Vocabulary = buildVocab(arr, Vocabulary, i, j, checkNumber);
        }
    }
    return Vocabulary;
}

// Строим одномерный словарь
int[] buildVocab(int[,] arr, int[] Vocab, int m, int n, int num)
{
    int isInCheckArray = 0;
    if(num == 1)
    {
        Array.Resize(ref Vocab, 1);
        Vocab[0] = arr[m,n];
    }
    for(int i = 0; i < Vocab.Length; i++)
    {
        if(Vocab[i] == arr[m, n])
        isInCheckArray++;
    }
    if(isInCheckArray == 0)
    {
        Array.Resize(ref Vocab, Vocab.Length + 1);
        Vocab[Vocab.Length - 1] = arr[m, n];
    }
    return Vocab;
}

// Делаем массив двумерным
int[,] makeVocabAndCount(int[] vocab)
{
    for(int i = 0; i < vocab.Length; i++)
    {
        VocabAndCount[i, 0] = vocab[i];
    }
    return VocabAndCount;
}

// Подсчитываем, сколько раз значение из словаря встречается в массиве
int[,] countNumsInVocabulary(int[,] arr, int[,] res)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < res.GetLength(0); k++)
            {
                if(res[k, 0] == arr[i, j])
                {
                    res[k, 1] += 1;
                }
            }
        }
    }
    return res;
}

//Печатаем
void PrintVocabularyAndCount(int[,] vocab)
{
    for(int i = 0; i < vocab.GetLength(0); i++)
    {
        Console.Write($"{vocab[i,0]} встречается ");
        Console.Write($"{vocab[i,1]} раз");
        Console.WriteLine();
    }
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

//Создаём результирующий массив для задачи 58
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
        return ComposArr;
    }
    else
    {
        Console.WriteLine("Количество столбцов у первой матрицы должно совпадать с количеством строк у второй матрицы!");
        return ComposArr;
    }
    
}



//Считаем произведения для результирующего массива для задачи 58
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

//Задача 60
int[,,] res = new int [2, 2, 2];
int[] Vocabulary = new int[0];
res = Get3DArray(res);

// Генерируем трёхмерный массив
int[,,] Get3DArray(int[,,] res)
{
    int num = 0;
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for(int j = 0; j < res.GetLength(1); j++)
        {
            for(int k = 0; k < res.GetLength(2); k++)
            {   
                num++;
                res[i, j, k] = new Random().Next(-9, 10);
                Vocabulary = buildVocab(res, Vocabulary, i, j, k, num);
            }
        }
    }
    return res;
}

// Строим одномерный словарь... (Да, мы это видели где-то выше)
int[] buildVocab(int[,,] arr, int[] Vocab, int m, int n, int o, int num)
{
    int isInCheckArray = 0;
    if(num == 1)
    {
        Array.Resize(ref Vocab, 1);
        Vocab[0] = arr[m,n,o];
    }
    for(int i = 0; i < Vocab.Length; i++)
    {
        if(Vocab[i] == arr[m, n, o])
        isInCheckArray++;
    }
    if(isInCheckArray == 0)
    {
        Array.Resize(ref Vocab, Vocab.Length + 1);
        Vocab[Vocab.Length - 1] = arr[m, n, o];
    }
    return Vocab;
}

res = CheckRandAndChange(res, Vocabulary);

// Увеличиваем рандомность массива - если число до этого уже было в массиве,
// то мы его ещё раз прорандомим!
int[,,] CheckRandAndChange(int[,,] arr, int[] vocabulary)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                for(int m = 0; m < vocabulary.Length; m++)
                {
                    if(vocabulary[m] == arr[i, j, k])
                    {
                        arr[i, j, k] = new Random().Next(-9, 10);
                    }
                }
            }
        }
    }
    return arr;
}

Print3DArray(Get3DArray(res));

// Печатаем 3д массив
void Print3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < res.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]}  {i},{j},{k}    ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}




// Получаем массив, заполненный рандомными числами, используется для всех задач
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

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


// Вообще, проект великоват, да((