// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите число - длину массива");
if(!int.TryParse(Console.ReadLine(), out int n) || n < 0)
{
Console.WriteLine("Введено нецелое или отрицательное число");
return;
}

void FillArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите число");
        if(!int.TryParse(Console.ReadLine(), out int A))
        {
            Console.WriteLine("Введено нецелое число");
            return;
        }
        array[i] = A;
    }
}
int[] array = new int[8];
FillArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Внимание, ваш массив:");
PrintArray(array);

int FindPositive(int[] array)
{
int count = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] > 0) count++;
}
return count;
}

Console.WriteLine();
int result = FindPositive(array);
Console.WriteLine($"Количество положительных чисел в массиве равно {result}");