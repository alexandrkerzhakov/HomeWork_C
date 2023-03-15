// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введено число - {number}");

Console.WriteLine(get_cubed(number));




String get_cubed(int N)
{
    String res = "";

    for (int i = 1; i <= N; i++)
    {
        res += $"{i * i * i},";
    }
    return res.Substring(0, res.Length - 1);
}