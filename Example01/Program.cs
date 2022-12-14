// Задайте двумерный массив размером m*n,
// заполненный случайными целыми числами.
// m = 3, n = 4.

using static Common.Helper;

Console.Clear();

int [,] array = Common.Helper.CreateRandom2DArray(3, 4);
Common.Helper.PrintArray(array);