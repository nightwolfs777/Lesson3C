#pragma warning disable
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int n;
Console.Write($"Введите 5-значное число: ");
int.TryParse(Console.ReadLine()!, out n);

int x1 = n / 10000;
int x2 = n / 1000 % 10;
int y1 = n % 100 / 10;
int y2 = n % 10;
if (x1 == y2 && x2 == y1)
    Console.WriteLine($"Число является палиндромом");
else
    Console.WriteLine($"Число не является палиндромом");