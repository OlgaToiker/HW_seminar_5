//Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите интервал начала и конца массива: ");
Console.Write("Начало интервала: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Конец интервала: ");
int maxValue = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];

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

Console.Write($"[");
Console.Write(string.Join(", ", array));
//PrintArray(array);
Console.Write($"]");

int sum = 0;
for (int i = 0; i < array.Length; i += 2)
    sum = sum + array[i];
Console.Write($"-> {sum}");