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


int[,] GetArray()
{
  int[,] array = new int[4, 5];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

void GetSum(int[,] array)
{
  int sum = 0, min = 0, i = 0;
  for (i = 0; i < array.GetLength(0); i++)
  {

    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum += array[i, j];
      min = sum;
      if (sum > min)
      {
        min += min;
        //Console.WriteLine(String.Format("Min row is {0}th row of sum {1}", i+1, sum));
      }
    }
    Console.WriteLine(String.Format("Summation of {0}th row is {1}", i + 1, sum));
    sum = 0;
  }
  Console.WriteLine();

  Console.WriteLine(String.Format("Min row is {0}th row of sum {1}", i + 1, min));
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


Console.Clear();
int[,] array = GetArray();
PrintArray(array);
GetSum(array);