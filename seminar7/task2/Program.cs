/* Задача 50. Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

int GetNum(string message)
{
  Console.Write(message);
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

int[,] GetArray()
{
  int[,] array = new int[4, 5];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }
  }
  return array;
}

bool FoundElement(int[,] array, int el)
{
  bool check = false;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == el)
      {
        Console.WriteLine(String.Format("Number on {0}th row in {1}th column is {2}", i+1, j + 1, el));
        check = true;
        break;
      }
      else
      {
        check = false;
      }
    }
  }
  return check;
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
int num = GetNum("Введите число, которое хотите найти: ");
if (FoundElement(array, num) == false)
{
  Console.WriteLine($"{num} -> такого числа в массиве нет");
}