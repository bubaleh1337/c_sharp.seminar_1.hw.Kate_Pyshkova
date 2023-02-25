/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();
int[] array = GetArray();
PrintArray(array);
Console.Write($" -> {GetSum(array)}");

int[] GetArray()
{
  int size = new Random().Next(5, 10);
  int[] array = new int[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(-100, 100);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
}

int GetSum(int[] array)
{
  int sum = 0;
  for (int i = 1; i < array.Length; i++)
  {
    if (i % 2 != 0) 
    {
      sum += array[i];
    }
  }
  return sum;
}