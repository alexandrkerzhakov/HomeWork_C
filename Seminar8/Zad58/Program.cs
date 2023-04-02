// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Console.Write("Введите количество строк для матрицы № 1: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для матрицы № 1: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwoDimensional1 = FillTwoDimensionalArray(rows, cols);
Console.WriteLine("Матрица № 1: ");
PrintTwoDimensionalArray(arrayTwoDimensional1);

Console.WriteLine($"Количество строк для матрицы № 2 равно количеству столбцов из матрицы № 1: {cols}");
Console.Write("Введите количество столбцов для матрицы № 2: ");
int cols2 = Convert.ToInt32(Console.ReadLine());
int[,] arrayTwoDimensional2 = FillTwoDimensionalArray(cols, cols2);
Console.WriteLine("Матрица № 2: ");
PrintTwoDimensionalArray(arrayTwoDimensional2);

int[,] multiplicationOfMatrix = GetMultiplicationOfMatrix(arrayTwoDimensional1, arrayTwoDimensional2);
Console.WriteLine("Произведение двух матриц:");
PrintTwoDimensionalArray(multiplicationOfMatrix);





int[,] FillTwoDimensionalArray(int r, int c)
{
    int[,] array = new int[r, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }
    }
    return array;
}




void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} \t");
        Console.WriteLine();
    }
}



int[,] GetMultiplicationOfMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplication = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    int mult = 0;
    int step = 0;
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1);)
        {
            while (step != matrixA.GetLength(0) - 1)
            {
                mult += matrixA[i, step] * matrixB[step, j];
                step++;
            }

            multiplication[i, j] = mult;
            // Console.WriteLine($"{multiplication[i, j],2} \t");
            step = 0;
            mult = 0;
            j++;
        }
    }
    return multiplication;
}