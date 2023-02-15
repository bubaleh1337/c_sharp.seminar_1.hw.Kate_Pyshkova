/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

  2, 3, 7 -> 7
  44 5 78 -> 78
  22 3 9 -> 22 */

int[] array1 = new int[] { 2, 3, 7 };
int[] array2 = new int[] { 44, 5, 78 };
int[] array3 = new int[] { 22, 3, 9 };
int max1 = 0, items1 = array1.Length;
int max2 = 0, items2 = array2.Length;
int max3 = 0, items3 = array3.Length;

for (int i = 0; i < items1; i++)
{
  if (array1[i] > max1) max1 = array1[i];
}
Console.WriteLine("Max number of 2, 3, 7 is " + max1);

for (int i = 0; i < items2; i++)
{
  if (array2[i] > max2) max2 = array2[i];
}
Console.WriteLine("Max number of 44, 5, 78 is " + max2);

for (int i = 0; i < items3; i++)
{
  if (array3[i] > max3) max3 = array3[i];
}
Console.WriteLine("Max number of 22, 3, 9 is " + max3);