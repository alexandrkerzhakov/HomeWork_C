// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введено число - {number}");

Console.WriteLine(boll_Check(isPalindrom(get_arr(number))));




int[] get_arr(int number)
{
    int[] raz = new int[5];
    int i = 0;

    while (number > 0)
    {
        raz[raz.Length - 1 - i] = number % 10;
        // Console.Write($"{raz[raz.Length - 1 - i]} ");
        number = number / 10;
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



