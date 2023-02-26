/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
int[] array = GetArray();
PrintArray(array);
Console.Write($" -> {GetDiff(array)}");

int[] GetArray()
{
  int size = new Random().Next(5, 10);
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 100);
  }
  return array;
}

void PrintArray(int[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
}

int GetDiff(int[] array)
{
  int min = 100, max = 0, result = 0;
  foreach (int el in array)
  {
    if (max < el) max = el;
    if (min > el) min = el;
  }
  result = max - min;
  return result;
}