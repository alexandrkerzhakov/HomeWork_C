// Число на разряды, выбираем 2-й разряд

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


// for (int i = 0; i < raz.Length; i++)
// {
//     Console.Write(raz[i] + " ");
// }
Console.WriteLine();

if (raz.Length > 1) {
    Console.WriteLine("Второе число : " + raz[1]);
    }
    else {
        Console.WriteLine("Число состоит из одного разряда");
    }

