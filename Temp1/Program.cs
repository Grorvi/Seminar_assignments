// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите число  = ");
int num = Math.Abs(int.Parse(Console.ReadLine()!));
int numTemp = num;
int count = 0;

while (numTemp > 0)
{
    numTemp /= 10;
    count++;
}

if (count - 3 >= 0)
    while (count -3 > 0)
    {
        num = num / 10;
        count--;
    }
Console.WriteLine($"Третья цифра {num % 10}");