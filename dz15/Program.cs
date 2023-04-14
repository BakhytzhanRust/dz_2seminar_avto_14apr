// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Enter number from 1 to 7, meant the day of the week ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 || x >7)
{
  Console.Write("You made mistake, that cannot mean the day of the week");
}
else
  if ( 1 <= x && x <= 5)
  {
    Console.Write($"{x} -> no");
  }
  else
  {
    Console.Write($"{x} -> yes");
  }