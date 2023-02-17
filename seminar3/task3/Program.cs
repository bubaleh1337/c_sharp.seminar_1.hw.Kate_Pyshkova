/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
* при N < 0, нужно вывести от N до -1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine()!);
int items = 1;
int negativeNum = number;

if (number < 0)
{
  items = number;
  negativeNum = -number;
  number = -1;
}

int[] array = new int[negativeNum];

for (int j = 0; items <= number; items++)
{
  array[j] = items * items * items;
  j++;
}
 
for (int j = 0; j < negativeNum; j++)
{
  Console.WriteLine($"{negativeNum} -> {array[j]}");
}