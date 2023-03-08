// Все четные до N

Console.WriteLine("Введите число");

int N = Convert.ToInt32( Console.ReadLine() );
int number = 1;

while(number <= N) {
    if (number %2 == 0) {
        Console.Write(number + " ");
    }
    number++;
}




