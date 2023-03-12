/* Задача 68: Напишите программу вычисления функции 
Аккермана с помощью рекурсии. Даны два неотрицательных 
числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Clear();
int m = Promt("Enter M number: ");
int n = Promt("Enter N number: ");
Console.WriteLine($"m = {m}, n = {n} -> A(m, n) = {Akkerman(m, n)}");

int Promt(string message)
{
  Console.Write(message);
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

int Akkerman(int m, int n)
{
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
  else return n + 1;
}

