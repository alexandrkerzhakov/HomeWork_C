// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = new Random().Next(1, 10);
int N = new Random().Next(1, 10);

if (M < N)
{
    Console.WriteLine($"Cумму натуральных элементов в промежутке от {M} до {N} -> {SumOfValueFromMtoN(M, N)}");
}
else
{
    Console.WriteLine($"Cумму натуральных элементов в промежутке от {M} до {N} не рассчитывается");
}




int SumOfValueFromMtoN(int number1, int number2)
{
    if (number2 == number1) return number1;
    return number2 + SumOfValueFromMtoN(number1, number2 - 1);
}
