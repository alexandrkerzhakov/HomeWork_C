Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = FillArray(size);
PrintArray(firstArray);
Console.WriteLine();

string[] getTA = GetTempArray(firstArray);
string[] getFUA = GetFinalUpdateArray(getTA, GetCountValue(firstArray));
PrintArray(getFUA);




string[] GetTempArray(string[] array)
{
    string[] getTempArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            getTempArray[j] = array[i];
            j++;
        }
    }
    return getTempArray;
}




int GetCountValue(string[] array)
{
    int countValue = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            countValue++;
        }
    }
    return countValue;
}




string[] GetFinalUpdateArray(string[] array, int count)
{
    string[] getFinalUpdateArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null)
        {
            getFinalUpdateArray[j] = array[i];
            j++;
        }
    }
    return getFinalUpdateArray;

}




string[] FillArray(int n)
{
    string[] array = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите значение для элемента массива с индексом {i}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}




void PrintArray(string[] array)
{
    Console.Write($"Выводим строковые значения элементов массива в консоль -> ");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1)
        {
            Console.Write($"\"{array[i]}\", ");
        }
        else
        {
            Console.Write($"\"{array[i]}\"");
        }
    }
    Console.Write("]");
}