// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа

int GetSecondDigit(int number)
{
    return (number / 10) % 10;
}

Console.Write("Введите трёхзначное число: ");
int Number = int.Parse(Console.ReadLine());

Console.WriteLine(GetSecondDigit(Number));