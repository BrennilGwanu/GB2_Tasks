// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число дня недели: ");
int day = int.Parse(Console.ReadLine()!);
if (day==6||day==7)
{
    Console.WriteLine("ДА!");
}
else
Console.WriteLine("Нет");