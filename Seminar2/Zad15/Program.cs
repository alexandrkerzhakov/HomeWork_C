// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число");
int number = Convert.ToInt32( Console.ReadLine() );

if (number%6 == 0 || number%7 == 0) {
    Console.WriteLine($"День недели c порядковым номером {number} выходной");
}
else {
    Console.WriteLine($"День недели c порядковым номером {number} не выходной");
}

