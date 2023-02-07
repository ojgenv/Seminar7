/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

Console.WriteLine("Введите m массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n массива");
int n = Convert.ToInt32(Console.ReadLine());

Print2DArray(Generate2DArray(m, n));

double[,] Generate2DArray(int m, int n)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(-99, 100);
            result[i, j] /= 10;
        }
    }
    return result;
}

void Print2DArray(double[,] arr)
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