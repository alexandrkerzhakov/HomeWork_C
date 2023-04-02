// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwoDimensional = FillTwoDimensionalArray(rows, cols);
Console.WriteLine("Двумерный массив: ");
PrintTwoDimensionalArray(arrayTwoDimensional);

Console.WriteLine($"Cтрока с наименьшей суммой элементов: {GetIndexOfRowsWihtMinSumOfElement(arrayTwoDimensional)}");




int[,] FillTwoDimensionalArray(int r, int c)
{
    int[,] array = new int[r, c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 31);
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




int GetIndexOfRowsWihtMinSumOfElement(int[,] arrayTD)
{
    int minSum = 0;
    int sum = 0;
    int indexRows = 0;
    for (int i = 0; i < arrayTD.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTD.GetLength(1); j++)
        {
            sum += arrayTD[i, j];
        }
        // Console.Write($"{sum} ");
        if (i == 0)
        {
            minSum = sum;
        }

        if (sum < minSum)
        {
            minSum = sum;
            indexRows = i;
        }
        sum = 0;
    }
    return indexRows;
}