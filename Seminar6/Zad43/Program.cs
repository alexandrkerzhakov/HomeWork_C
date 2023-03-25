// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
coordinatesIntersectionLine();




void coordinatesIntersectionLine()
{
    Console.WriteLine("Введи коэффициент k1");
    double k1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введи переменную b1");
    double b1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введи коэффициент k2");
    double k2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введи переменную b2");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 != k2)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = (k1 * x + b1); // || double y = (k2 * x + b2)
        Console.WriteLine($"Для прямых, заданных уравнениями:\ny1 = {k1}*x + {b1}\ny2 = {k2}*x + {b2}");
        Console.WriteLine($"Точка пересечения имеет координаты x,y -> ({x};{y})");
    }
    else
    {
        Console.WriteLine("Прямые не пересекаются");
    }
}


