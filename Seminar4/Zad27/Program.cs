// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int getSumOfDigitInNumber()
{
    int sum = 0;
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма цифр в числе {number} = ");
    while (number > 0)
    {
        sum += number%10;
        number = number/10;

    }
    
    return sum;
}
Console.Write($"{getSumOfDigitInNumber()}");