// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == number / 2)
{
    System.Console.WriteLine("The number is even!");
}
else
{
    System.Console.WriteLine("The number is not even!");
}