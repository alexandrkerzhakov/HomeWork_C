// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int number_to_power()
{
    int res = 1;
    Console.WriteLine("Введите число A");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int B = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= B; i++)
    {
        res *= A;
    }
    Console.Write($"Число {A} в степени {B} = ");
    return res;
}
Console.Write($"{number_to_power()}");