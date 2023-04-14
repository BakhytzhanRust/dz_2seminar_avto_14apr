// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Enter three-numbered count ");
int n3 = Convert.ToInt32(Console.ReadLine());
if (n3 < 100 || n3 > 1000)
{
 Console.WriteLine("That's not three-numbered count, please, try again");
}
else
{
int n2 = n3 % 100 / 10;
Console.WriteLine($" {n3} -> {n2}");
}
