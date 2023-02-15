/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

int numberA = 5, numberB = 8;

for (int i = 1; i <= numberA; i++)
{
  if (i % 2 == 0) Console.WriteLine("All even numbers to " + numberA + " is " + i);
}

Console.WriteLine("--------------------------");

for (int i = 1; i <= numberB; i++)
{
  if (i % 2 == 0) Console.WriteLine("All even numbers to " + numberB + " is " + i);
}