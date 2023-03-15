// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введено число - {number}");

Console.WriteLine(boll_Check(isPalindrom(get_arr(number))));


int get_raz(int n) {
    int raz = 0;
    while (n > 0)
    {
        n = n / 10;
        raz++;
    }
    return raz;
}


int[] get_arr(int n)
{
    int[] raz = new int[get_raz(n)];
    int i = 0;

    while (n > 0)
    {
        raz[raz.Length - 1 - i] = n % 10;
        // Console.Write($"{raz[raz.Length - 1 - i]} ");
        n = n / 10;
        i++;
    }
    return raz;
}




bool isPalindrom(int[] arr)
{
    bool isP = false;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        if (arr[i] == arr[arr.Length - 1 - i])
        {
            isP = true;
        }
        else
        {
            isP = false;
            break;
        }
    }
    return isP;
}




String boll_Check(bool b)
{
    if (b)
    {
        return "Число является палиндромом";
    }
    else
    {
        return "Число не является палиндромом";
    }
}



