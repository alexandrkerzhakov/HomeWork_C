// Максимум из 3-х чисел

Console.WriteLine("Введите 3 числа, после каждого нажмите enter");

int number1 = Convert.ToInt32( Console.ReadLine() );
int number2 = Convert.ToInt32( Console.ReadLine() );
int number3 = Convert.ToInt32( Console.ReadLine() );

int max = number1;

if (max > number2) {
    if (max > number3) {

    }
    else {
        max = number3;
    }
}
else {
    max = number2;
    if (max > number3) {
        
    }
    else {
        max = number3;
    }
}
Console.WriteLine("Максимальное число: " + max);
