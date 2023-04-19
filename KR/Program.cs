Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] firstArray = FillArray(size);
PrintArray(firstArray);
Console.WriteLine();

int countValue = 0;
string[] getTA = GetTempArray(firstArray);
string[] getFUA = GetFinalUpdateArray(getTA);
PrintArray(getFUA);




string[] GetTempArray(string[] array)
{
    string[] getTempArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            getTempArray[countValue] = array[i];
            countValue++;
        }
    }
    return getTempArray;
}




string[] GetFinalUpdateArray(string[] array)
{
    string[] getFinalUpdateArray = new string[countValue];
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