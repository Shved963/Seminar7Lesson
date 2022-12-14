// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса нечётные, и замените эти элементы на их
// квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядетьнечетный вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
Console.Clear();
Console.WriteLine("Введите размерность двумерного массива");
double[,] array = CreateRandom2DArray();
PrintArray(array);
//double[,] unevenSquareArray = GetArrayWithUnevenSquare(array);
Console.WriteLine();
PrintArray(GetArrayWithUnevenSquare(array));

double[,] GetArrayWithUnevenSquare(double[,] array)
{
    double[,] arraySquare = new double[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < arraySquare.GetLength(0); i++)
    {
        for (int j = 0; j < arraySquare.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                arraySquare[i, j] = Math.Pow(array[i, j], 2);
            }
            else
            {
                arraySquare[i, j] = array[i, j];
            }
        }
    }
    return arraySquare;
}


double[,] CreateRandom2DArray()
{
    int countOfRow = Common.Helper.IntoInt();
    int countOfColums = Common.Helper.IntoInt();

    double[,] array = new double[countOfRow, countOfColums];
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

void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
