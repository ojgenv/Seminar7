/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

Console.WriteLine("Введите m массива");
int arrayHeight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n массива");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[,] arr = Generate2DArray(arrayHeight, arrayLength);
Print2DArray(arr);

Console.WriteLine("Введите координату массива по вертикали");
int coordArrayHeight = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите координату массива по горизонтали");
int coordArrayLength = Convert.ToInt32(Console.ReadLine()) - 1;

if (checkArray(arr, coordArrayHeight, coordArrayLength))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine(arr[coordArrayHeight, coordArrayLength]);
}

bool checkArray(int[,] arr, int coor, int coor2)
{
    return (arr.GetLength(0) <= coor || arr.GetLength(1) <= coor2);
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
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