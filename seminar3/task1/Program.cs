/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

  14122 -> нет

  12821 -> да

  23432 -> да */

Console.Clear();
Console.Write("Enter a five-digit number: ");
int number = int.Parse(Console.ReadLine()!);

if (9999 > number || number <= 99999)
{
  int firstHalf = number / 1000; // 12821 / 1000 = 12
  int secondHalf = number % 100; // 12821 % 100 = 21  [21*10 = 210 + 2 = 212 = 12]
  secondHalf = secondHalf * 10 + secondHalf % 100 / 10;
  secondHalf %= 100;
  if (firstHalf == secondHalf)
  {
    Console.WriteLine($"{number} -> yes");
  }
  else
  {
    Console.WriteLine($"{number} -> no");
  }
}
else
{
  Console.WriteLine("Error. Please, enter a five-digit number.");
}