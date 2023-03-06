/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

using System;
using static System.Console;

Clear();
int m = Prompt("Введите число m: ");
int n = Prompt("Введите число n: ");
double[,] array = GetArray(m, n);
PrintArray(array);

int Prompt (string message)
{
  Write(message);
  int num = int.Parse(ReadLine()!);
  return num;
}

double[,] GetArray (int m, int n)
{
  double[,] array = new double[m, n];
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * (10 - (-10)) + (-10);
    }
  }
  return array;
}

void PrintArray(double[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Write($"{array[i, j]:f1} ");
    }
    WriteLine();
  }
}

