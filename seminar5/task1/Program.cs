/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();
int[] array = GetArray();
PrintArray(array);
Console.Write($" -> {GetEvenNumbers(array)}");


int[] GetArray()
{
  int size = new Random().Next(5, 15);
  int[] array = new int [size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(99, 1000);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
}

int GetEvenNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0)
    {
      count++;
    }
  }
  return count;
}