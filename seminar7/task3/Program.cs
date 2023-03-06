/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее 
арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int GetRowsColumns(string message)
{
  Console.Write(message);
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

int[,] GetArray(int rows, int columns)
{
  int[,] array = new int[rows, columns];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

void GetAverage(int[,] array, int rows, int columns)
{
  float average = 0, sum = 0;

  for (int j = 0; j < columns; ++j)
  {
    for (int i = 0; i < rows; ++i)
    {
      sum += array[i, j];
    }
    average = sum / columns;
    Console.WriteLine(String.Format("Summation of {0}th column is {1}", j+1, average));
    sum = 0;
  }
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
int rows = GetRowsColumns($"Enter rows: ");
int columns = GetRowsColumns("Enter columns: ");
int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine($"Average of each columns: ");
GetAverage(array, rows, columns);
