// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine()!);
int[] newarray(int size)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(0, 100);
    }
    return res;
}

void PrintArray(int[] size)
{
    for (int j = 0; j < size.Length; j++)
    {
        Console.Write(size[j] + " ");
    }
}
int[] array = newarray(size);
Console.WriteLine("Наш массив: ");
Console.Write("[");
PrintArray(array);
Console.Write("] --> ");

int max = 0;
int min = 0;

foreach (int el in array)
{
    if (max < el) max = el;
    else min = el;
}
Console.WriteLine($"\n Максимальный элемент: {max}\n Минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");
