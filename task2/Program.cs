/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
(делится ли оно на два без остатка).

  4 -> да
  3 -> нет
  7 -> нет */

int[] array = new int[] { 4, 3, 7 };
int items = array.Length;

for (int i = 0; i < items; i++)
{
  if (array[i] % 2 == 0) Console.WriteLine("Even number of 4, 3, 7: " + array[i]);
  else Console.WriteLine("Odd number of 4, 3, 7: " + array[i]);
}