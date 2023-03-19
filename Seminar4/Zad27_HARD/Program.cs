// Напишите программу, которая принимает на вход число (целое, вещественное, в экспоненциальной форме) и выдаёт сумму цифр в числе.
Console.Write("Введите число: ");
Console.WriteLine($"Сумма цифр в числе = {get_result()}");




int get_result()
{
    int result;
    String n = Console.ReadLine();
    String[] arr = n.Split(",");
    String v1 = update_substr_arr(arr[0]);
    String v2 = update_substr_arr(arr[1]);
    result = getSumOfDigitInStringN(v1) + getSumOfDigitInStringN(v2); // сумма для двух строк (число с "," разделено на 2 подстроки)
    return result;
}




// удаляем "e" из строки и "0" в начале строки
String update_substr_arr(String value)
{
    if (value.StartsWith("0"))
    {
        while (value.StartsWith("0"))
        {
            value = value.Substring(1, value.Length - 1);
        }
    }

    if (value.IndexOf("e") != -1)
    {
        value = value.Replace("e", "");
    }
    return value;
}




// сумма цифр в числе n в формате String
int getSumOfDigitInStringN(String n)
{
    int sum = 0;
    try
    {
        int number = Convert.ToInt32(n);
        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Ошибка конвертация строки");
    }
    return sum;
}


