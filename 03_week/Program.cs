// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int week = int.Parse(Console.ReadLine() ?? "0");

if (week == 6 || week == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}







