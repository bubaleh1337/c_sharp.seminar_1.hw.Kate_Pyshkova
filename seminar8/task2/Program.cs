/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с 
наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();
int[,] array = GetArray();
PrintArray(array);
Console.WriteLine();
MinSum(array);

int[,] GetArray()
{
  int[,] array = new int[4, 4];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

void MinSum(int[,] arr)
{
  int sum = 0, min = Int32.MaxValue, minRow = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum += arr[i, j];

    }
    Console.WriteLine("Sum of row [{0}]: {1}", (i + 1), sum);
    if (sum < min)
    {
      min = sum;
      minRow = i;
    }
  }
  Console.WriteLine();
  Console.WriteLine("Min row [{0}], min sum = {1}", (minRow + 1), min);
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}
