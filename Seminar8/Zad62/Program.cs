// Напишите программу, которая заполнит спирально массив 4 на 4.
Console.Write("Введите число, последовательность цифр от единицы до квадрата которого будет записана по спирали в двумерный массив : ");
int number = Convert.ToInt32(Console.ReadLine());
int[,] spiralArray = GetSpiralArray(number);
Console.WriteLine("Двумерный массив: ");
PrintTwoDimensionalArray(spiralArray);




int[,] GetSpiralArray(int n)
{
    int[,] arr = new int[n, n];
    int count = 1; // 1-е число
    int endNumber = n * n; // конечное число

    int left = 0; // левая граница
    int right = n; // правая граница
    int up = 0; // верхняя граница
    int down = n; // нижняя граница

    int i = 0; // индекс по горизонтали
    int j = 0; // индекс по вертикали

    while (count <= endNumber)
    {
        // 1. Идем вправо
        arr[i, j] = count; // Значение верхнего левого числа
        while (j < right - 1)
        {
            j++;
            count++;
            arr[i, j] = count;
        }

        up++;
        i = up;
        count++;

        // 2. Идем вниз
        arr[i, j] = count; // Значение верхнего правого числа после смещения верхней границы
        while (i < down - 1)
        {
            i++;
            count++;
            arr[i, j] = count;
        }

        right--;
        j = right - 1;
        count++;

        // 3. Идем влево
        arr[i, j] = count; // Значение нижнего правого числа после смещения правой границы
        while (j > left)
        {
            j--;
            count++;
            arr[i, j] = count;
        }

        down--;
        i = down - 1;
        count++;

        // 4. Идем вверх
        while (i >= up)
        {
            arr[i, j] = count;
            i--;
            count++;
        }
        left++;
        i = up;
        j = left;
    }
    return arr;
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