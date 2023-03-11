// На входе от пользователя целое число любой разрядности, надо удалить вторую цифру слева направо этого числа.

Console.WriteLine("Введите число");

int N = Convert.ToInt32( Console.ReadLine() );
int count_raz = 0;
int[] tmp_raz = new int[32];

while(N > 0) {
    tmp_raz[count_raz] = N % 10;
    // Console.Write(tmp_raz[count_raz]);
    count_raz++;
    N = N / 10;
}
Console.WriteLine();

int[] raz = new int[count_raz];
Array.Copy(tmp_raz, raz, count_raz);
Array.Reverse(raz);
Console.WriteLine();

Console.Write("Число без 2-го разряда: ");
if (raz.Length > 1) {
    for (int i = 0; i < raz.Length; i++) {
        if (i != 1) {
        Console.Write(raz[i]);
        }
    }
}
else {
        Console.WriteLine($"Число состоит из одного разряда: {raz[0]}");
}


