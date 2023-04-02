// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Write("Введите параметр 1-й мерности: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите параметр 2-й мерности: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите параметр 3-й мерности: ");
int depth = Convert.ToInt32(Console.ReadLine());

int[,,] array = FillThreeDimensionalArray(length, width, depth);
PrintThreeDimensionalArray(array);

int[,,] FillThreeDimensionalArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int number = new Random().Next(1, 31);
                while (!Uniqueness(number, array))
                {
                    number = new Random().Next(1, 31);
                }
                array[i, j, k] = number;
            }
        }
    }
    return array;
}




bool Uniqueness(int number, int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j, k] == number)
                {
                    return false;
                }
            }
        }
    }
    return true;
}




void PrintThreeDimensionalArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, k],2} ({i},{j},{k}) \t ");
            }
            Console.WriteLine("");
        }
    }
}