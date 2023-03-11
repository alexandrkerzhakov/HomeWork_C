// Максимум из 2-х чисел

Console.WriteLine("Введите 2 числа, после каждого нажмите enter");

int number1 = Convert.ToInt32( Console.ReadLine() );
int number2 = Convert.ToInt32( Console.ReadLine() );

if (number1 > number2) {
    Console.WriteLine("Наибольшее число : " + number1);
    Console.WriteLine("Наименьшее число : " + number2);
}
else {
    Console.WriteLine("Наибольшее число : " + number2);
    Console.WriteLine("Наименьшее число : " + number1);
}


