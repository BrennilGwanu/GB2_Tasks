// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Введите трёхначное число: ");
int number = int.Parse(Console.ReadLine()!);
int num = number / 10 % 10;
Console.WriteLine(num);