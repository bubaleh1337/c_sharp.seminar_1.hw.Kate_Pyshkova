/* Задача 27: Напишите программу, которая принимает на вход 
число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();
Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{num} -> {GetNumberSum(num)}");

int GetNumberSum(int nums)
{
  int result = 0;
  while (nums > 0) 
  {
    result += nums % 10;
    nums /= 10;
  }
  return result;
}