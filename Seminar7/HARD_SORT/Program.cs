// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
//  Отсортировать элементы по возрастанию слева направо и сверху вниз.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arrayTwoDimensional = FillTwoDimensionalArray(rows, cols);
Console.WriteLine("Двумерный массив: ");
PrintTwoDimensionalArray(arrayTwoDimensional);

int[] arrayOneDimensional = FillOneDimensionalArray(arrayTwoDimensional);
int[] sortArray = SortArray(arrayOneDimensional);

int[,] arrayTwoDimensionalSort = FillTwoOfOneDimensionalArray(sortArray, rows, cols);
Console.WriteLine("Отсортированный двумерный  массив: ");
PrintTwoDimensionalArray(arrayTwoDimensionalSort);




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




int[] FillOneDimensionalArray(int[,] array)
{
    int[] arr = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[k] = array[i, j];
            k++;
        }
    }
    return arr;
}





int[] SortArray(int[] array)
{
    int size = array.Length;
    while (size > 1)
    {
        int i = 0;
        while (i < size - 1)
        {
            if (array[i] > array[i + 1])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
            i++;
        }
        size--;
    }
    return array;
}




int[,] FillTwoOfOneDimensionalArray(int[] array, int r, int c)
{
    int[,] arr = new int[r, c];
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = array[k];
            k++;
        }
    }
    return arr;
}




// void PrintOneDimensionalArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }