// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int get_length_arr() {
    Console.WriteLine("Введите длину масссива");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

int[] get_arr(int length) {
    int[] arr = new int[length];
    for (int i = 0; i < length; i++) {
        Console.WriteLine("Введите значение очередного элемента массива"); // Console.WriteLine("Значение очередного элемента массива");
        int value = Convert.ToInt32(Console.ReadLine()); // new Random().Next(1, 100000);
        arr[i] = value;
    }
    return arr;
}

void print_arr(int[] arr) {
    Console.Write("Выводим значения элементов массива: ");
    for (int i = 0; i < arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
}

int[] array = get_arr(get_length_arr());
print_arr(array);
