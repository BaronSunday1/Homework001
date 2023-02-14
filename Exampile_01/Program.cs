// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int min = number1;
int max = number1;
if (number1 > max)
{
    max = number1;
}
if (number1 < min)
{
    min = number1;
}
if (number2 > max)
{
    max = number2;
}
if (number2 < min)
{
    min = number2;
}
System.Console.WriteLine($"Minimal value: {min} Maksimal value: {max}");
