// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Будем искать точку пересечения прямых, заданных в формате y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите число k1");
if(!int.TryParse(Console.ReadLine(), out int k1))
{
    Console.WriteLine("Введено нецелое число");
}
Console.WriteLine("Введите число b1");
if(!int.TryParse(Console.ReadLine(), out int b1))
{
    Console.WriteLine("Введено нецелое число");
    return; 
}
Console.WriteLine("Введите число k2");
if(!int.TryParse(Console.ReadLine(), out int k2))
{
    Console.WriteLine("Введено нецелое число");
}
Console.WriteLine("Введите число b2");
if(!int.TryParse(Console.ReadLine(), out int b2))
{
    Console.WriteLine("Введено нецелое число");
    return; 
}

if (k1 == k2)
{
    Console.WriteLine("Параллельные прямые не пересекаются, доказано Эвклидом");
    return;
}

double[] FindIntersection (double k1, double b1, double k2, double b2)
{
double[] result = new double [2];
result[0] = ((b2-b1) / (k1-k2));
result[1] = result[0]*k1 + b1;
return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

double[] array = FindIntersection(k1, b1, k2, b2);
Console.WriteLine("Внимание, координаты точки пересечения:");
PrintArray(array);




