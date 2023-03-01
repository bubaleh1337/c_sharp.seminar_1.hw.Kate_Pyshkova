/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();

int size = Prompt("Введите количество элементов > ");
int[] array = GetArray(size);
Console.Write($"{String.Join(", ", array)} -> {CountPositiveNumbers(array)}");

int Prompt(string message)
{
  Console.Write(message);
  string num = Console.ReadLine()!;
  int result = Convert.ToInt32(num);
  return result;
}

int[] GetArray(int size)
{
  int[] array = new int[size];
  for (int i = 0; i < array.Length; i++)
    array[i] = Prompt($"Enter {i + 1}-element: ");
  return array;
}

int CountPositiveNumbers(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++) if (array[i] > 0)
      count++;
  return count;
}