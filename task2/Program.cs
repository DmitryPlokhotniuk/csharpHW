﻿Console.WriteLine("Введите 3 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (number1 > number2)
{
    max = number1;
}
else
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine("Максимальное число - " + max);