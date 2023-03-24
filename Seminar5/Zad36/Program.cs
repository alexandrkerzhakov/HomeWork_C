// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine($"Сумма элементов с четными индексами = {getSumValueOnEvenIndexFromArray()}");




int getSumValueOnEvenIndexFromArray()
{
    int sum = 0;
    int length = new Random().Next(1, 10);

    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
        Console.Write($"{arr[i]} ");
        if (i % 2 == 0)
        {
            sum += arr[i];
        }
    }
    Console.WriteLine("");
    return sum;
}

