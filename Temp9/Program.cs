// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33] 

Console.Clear();
Console.Write("Введите количество элементов массива:\t");
int PrintRandArray = int.Parse(Console.ReadLine()!);
int[] myArray = new int[PrintRandArray];
int[] GetNewArr(int[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВедите элемент массива под индексом {i}:\t ");
        myArray[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine("Выод массива:");
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ", ");
    }
    return myArray;
}
GetNewArr(myArray);