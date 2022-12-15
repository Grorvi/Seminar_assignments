// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
int sum = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}


Console.WriteLine("Сумма не четных элементов {0}", sum);
Console.ReadKey();