Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
System.Console.WriteLine($"Maksimal number: {max}");