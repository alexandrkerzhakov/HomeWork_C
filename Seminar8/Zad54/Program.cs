// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwoDimensional = FillTwoDimensionalArray(rows, cols);
Console.WriteLine("Двумерный массив: ");
PrintTwoDimensionalArray(arrayTwoDimensional);
SortTwoDimensionalArray(arrayTwoDimensional); // сортировка построчно
Console.WriteLine("Отсортированный построчно двумерный массив: ");
PrintTwoDimensionalArray(arrayTwoDimensional);




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




int[,] SortTwoDimensionalArray(int[,] array)
{
    int[] tmpArray = new int[array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tmpArray[k] = array[i, j];
            k++;
        }
        SortArray(tmpArray);
        FillTwoFromOneDimensionalArrayByRows(tmpArray, array, i);
        k = 0;
    }
    return array;

}




int[] SortArray(int[] array)
{
    int size = 0;
    while (size != array.Length - 1)
    {
        int i = array.Length - 1;
        while (i > size)
        {
            if (array[i - 1] < array[i])
            {
                (array[i - 1], array[i]) = (array[i], array[i - 1]);
            }
            i--;
        }
        size++;
    }
    return array;
}




void FillTwoFromOneDimensionalArrayByRows(int[] arrayOD, int[,] arrayTD, int rows)
{
    int k = 0;
    for (int j = 0; j < arrayTD.GetLength(1); j++)
    {
        arrayTD[rows, j] = arrayOD[k];
        k++;
    }
}




// void PrintOneDimensionalArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }