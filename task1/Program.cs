Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine(number1 + " > " + number2);
}
else
{
    Console.WriteLine(number2 + " > " + number1);
}
