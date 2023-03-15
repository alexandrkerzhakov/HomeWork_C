// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.
Console.WriteLine("Введите мерность пространства");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введено число - {N}");

Console.WriteLine("Введите значения для 1-го пространства");
int[] space1 = get_array_filling(N);
Console.WriteLine("Введите значения для 2-го пространства");
int[] space2 = get_array_filling(N);
double[] arr = get_arr_result(space1, space2);
Console.WriteLine($"Расстояние = " + get_result(arr));

// Console.WriteLine(get_result(get_arr_result(get_array_filling(N), get_array_filling(N))));

int[] get_array_filling(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите значение координаты i{i+1} ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}




double[] get_arr_result(int[] arr1, int[] arr2)
{
    double[] arr_result = new double[arr1.Length];
    for (int i = 0; i < arr_result.Length; i++)
    {
        arr_result[i] = (arr2[i] - arr1[i]) * (arr2[i] - arr1[i]);
    }
    return arr_result;
}




double get_result(double[] arr)
{
    double res_sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        res_sum += arr[i];
    }
    return Math.Sqrt(res_sum);
}