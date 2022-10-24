// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.


Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");

if (Number < 100)
{
    Console.WriteLine("Нет третьей цифры");
}
else if (Number > 100 && Number < 999)
{
    Console.WriteLine($"{Number % 10}");
}
else
{
    do
    {
        Number = Number / 10;
    }
    while (Number > 999);

    Console.WriteLine(Number % 10);
}