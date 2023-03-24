// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {getDifMaxMin(getArray())}");




double getDifMaxMin(double[] arr) {
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) {
            max = arr[i];
        }
        if (arr[i] < min) {
            min = arr[i];
        }

    }
    return max - min;
}




double[] getArray()
{
    int length = new Random().Next(1, 10);

    double[] arr = new double[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Math.Round(new Random().Next(1, 100) * new Random().NextDouble(), 1);
        Console.Write($"{arr[i]} ");

    }
    Console.WriteLine("");
    return arr;
}
