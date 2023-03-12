// * Задача 2:*Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных 
// элементов
// в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.Write("Enter number for start: ");
int start = int.Parse(Console.ReadLine()!);
Console.Write("Enter number for end: ");
int end = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"M = {start}; N = {end} -> {SortNumbers(start, end)}");

int SortNumbers(int start, int end)
{
  if (end == start)
    return end;
  return end + SortNumbers(start, end - 1);
}