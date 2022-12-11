// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число: ");
int i = int.Parse(Console.ReadLine()!);
int GetSumNums(int number)
{
    int sum = 0;
    while (i > 0)
    {
        int num = i % 10;
        i = i / 10;
        sum = sum + num;
    }
    return sum;
}
Console.WriteLine($"Сумма цифр = {GetSumNums(i)}");