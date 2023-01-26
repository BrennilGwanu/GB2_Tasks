// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int num = number / 100;
if (num==0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    num = num % 10;
    Console.WriteLine(num);
}