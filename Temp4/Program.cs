// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите число ");
int a = 0;
int b;
int y;
int n = int.Parse(Console.ReadLine()!);
y = n;

while (n != 0)
{
    b = n % 10;
    a = a * 10 + b;
    n = n / 10;
}
if (y == a)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}