// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter count x ");
double x = Convert.ToInt32(Console.ReadLine());
int lengthX = 1;
if (x > 0 && x < 100)
{
  Console.WriteLine("There is no the third-number");
}
else if (x < 0)
{
  Console.WriteLine("This is negative count");
}
else if (x >= 100)
{
  while (x >= 10)
  {
    x = x / 10;
    if (x >= 10)
    {
      lengthX++;
    }
  }
}
x = x * Math.Pow(10,lengthX-1);
int numZh1 = Convert.ToInt32(x % (Math.Pow(10, lengthX-2)));
int numZh2 = Convert.ToInt32(numZh1 % (Math.Pow(10, lengthX - 3)));
int numFinal = Convert.ToInt32(numZh2 / (Math.Pow(10, lengthX - 4)));
Console.Write(numFinal);


// if (x < 100 && x > 0)
// {
//   Console.WriteLine($"{x} -> There is no third count");
// }