// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3



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

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write(myArray[i] + ", ");
    }
    return myArray;
}
int count = 0;
GetNewArr(myArray);
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Кол-во элементов > 0: {count}");