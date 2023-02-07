/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите m массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n массива");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = Generate2DArray(m, n);
Print2DArray(arr);
avgColumns(arr);

void avgColumns(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        int sum = sumColumn(arr, i);
        double avg = Convert.ToDouble(sum) / arr.GetLength(0);
        Console.WriteLine(avg);
    }
}

int sumColumn(int[,] arr, int column)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, column];
    }
    return sum;
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}