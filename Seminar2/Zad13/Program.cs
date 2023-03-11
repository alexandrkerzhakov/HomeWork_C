// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число");
int number = Convert.ToInt32( Console.ReadLine() );
int third = 0;

if (number/100 > 0) {
    while (number/100 > 0) {
        third = number%10;
        // Console.Write($"{third} ");
        number = number/10;
        // Console.Write($"{number} ");
    }
    Console.WriteLine($"Третья цифра числа: {third} ");
} else {
    Console.WriteLine("Третьей цифры нет");
    }

