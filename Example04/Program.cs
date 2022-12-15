// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

using static Common.Helper;

Console.Clear();
Console.WriteLine("Введите размер массива");
Console.WriteLine();
int [,] array = CreateRandom2DArray();
Common.Helper.PrintArray(array);
int sumMainElements = GetSumMainElements(array);
Console.WriteLine(sumMainElements);


int GetSumMainElements(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                sum = sum + array[i,j];
            }
        }
    }
    return sum;
}


int[,] CreateRandom2DArray()
{
    int countOfRow = Common.Helper.IntoInt();
    int countOfColums = Common.Helper.IntoInt();
    if (countOfColums <= 0 || countOfRow <= 0)
    {
        throw new ArgumentException("Введен не корректный размер матрицы");
    }

    int[,] array = new int[countOfRow, countOfColums];
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}