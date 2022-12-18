// Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите интервал начала и конца массива: ");
Console.Write("Начало интервала: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Конец интервала: ");
int maxValue = int.Parse(Console.ReadLine()!);
//int [] array = new int[size];

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] array = GetArray(size, minValue, maxValue);
//int[] array = new int[size];

Console.Write($"[");
Console.Write(string.Join(", ", array));
Console.Write($"]");

int findMin(int[] array)
{
    int min = int.MaxValue;
    foreach (var i in array)
    {
    if (i < min)    min = i;
    }
    return min;
}

int findMax(int[] array)
{
    int max = int.MinValue;
    foreach (var i in array)
    {
    if (i > max) max = i;
    }
    return max;
}
Console.Write($"-> {findMax(array)-findMin(array)}");