// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
using static Common.Helper;
Console.Clear();
Console.WriteLine("Введите размерность двумерного массива");
int[,] array = Create2DArray();

Common.Helper.PrintArray(array);



int[,] Create2DArray()
{
    int countOfRow = Common.Helper.IntoInt();
    int countOfColums = Common.Helper.IntoInt();
    
    int[,] array = new int[countOfRow, countOfColums];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }

    return array;
}