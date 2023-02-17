/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
* при N < 0, нужно вывести от N до -1
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();

Console.Write("Enter a number: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i < N; i++)
{
  double result = Math.Pow(i, 3);
  Console.Write($"{N} -> {result} | "); 
} 