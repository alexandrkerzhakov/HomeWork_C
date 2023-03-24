// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine($"Количество четных элементов в массиве = {getCountEvenValueFromArray()}");




int getCountEvenValueFromArray()
{
    int count = 0;
    int length = new Random().Next(1, 10);

    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(100, 999);
        Console.Write($"{arr[i]} ");
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine("");
    return count;
}
