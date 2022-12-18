// Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество
// чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] numbers = new int[size];
RandonNumbers(numbers);

void RandonNumbers(int[] numbers)
{
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

int count = 0;
for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] % 2 == 0)
        count++;
}

Console.Write($"[");
Console.Write(string.Join(", ", numbers));
Console.Write($"]");
Console.Write($"-> {count}");