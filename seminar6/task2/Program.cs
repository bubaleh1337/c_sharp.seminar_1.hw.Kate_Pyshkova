/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

int k1 = Prompt($"Enter the number k1: ");
int b1 = Prompt($"Enter the number b1: ");
int k2 = Prompt($"Enter the number k2: ");
int b2 = Prompt($"Enter the number b2: ");
Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ");
GetPoint(k1, b1, k2, b2);


int Prompt(string message)
{
  Console.Write(message);
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

void GetPoint(int k1, int b1, int k2, int b2)
{
  int x = (b2 - b1) / (k1 - k2);

  int y = k1 * x + b1;
  Console.Write($" -> ({x}; {y})");
}
