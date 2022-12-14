// Задайте двумерный массив размером m*n,
// заполненный случайными целыми числами.
// m = 3, n = 4.

using static Common.Helper;
//2D Array
/*Console.Clear();

int [,] array = Common.Helper.CreateRandom2DArray(3, 4);
Common.Helper.PrintArray(array);*/


// Tuples
/*
(int, int) coordinates = GetSomthing();
Console.WriteLine(coordinates.Item1);
Console.WriteLine(coordinates.Item2);

(int, int) GetSomthing()
{
    int a = 5;
    int b = 10;
    return(a, b);
}
*/

int [] array = new int[3]{1,3,4};

string str = string.Join(", ",array);
Console.WriteLine(str);

string strFormat = string.Format("это лзааы{0} равно аыавы {1} dsdsdad {2}", 1, 2, 3);

string str2 = $"{str}";

string.Concat("", "", "");
//string.Empty(); //создание пустой строки
//string.IsNullOrWhiteSpace();
