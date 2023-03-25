// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
// для положительных F0 = 0, F1 = 1, Fn = Fn-1 + Fn-2
// для отрицательных F0 = 0, F-1 = 1, Fn = Fn+2 - Fn+1

int[] arr = getFibonachiArray();
printArray(arr);




int[] getFibonachiArray()
{
    Console.Write("Введите длину числовой последовательности Фибоначи: ");
    int k = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[k * 2 - 1];
    arr[arr.Length / 2] = 0;
    arr[arr.Length / 2 + 1] = arr[arr.Length / 2 - 1] = 1;

    for (int i = 2; i < k; i++)
    {
        arr[arr.Length / 2 + i] = arr[arr.Length / 2 + i - 1] + arr[arr.Length / 2 + i - 2];
        arr[arr.Length / 2 - i] = arr[arr.Length / 2 - i + 2] - arr[arr.Length / 2 - i + 1];
    }
    return arr;
}




void printArray(int[] array)
{
    Console.Write("Array: ");
    foreach (int value in array)
    {
        Console.Write($"{value} ");
    }
}
