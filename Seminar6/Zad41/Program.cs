// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите длину числовой последовательности: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = getArray(M);
printArrayWithCountPositive(array);



int[] getArray(int size) {
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Элемент {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}




void printArrayWithCountPositive(int[] array) {
    int countPositive = 0;
    Console.Write("Array: ");
    foreach(int value in array) {
        Console.Write($"{value} ");
        if (value > 0) {
            countPositive++;
        }
    }
    Console.Write($"--> положительных: {countPositive}");
}