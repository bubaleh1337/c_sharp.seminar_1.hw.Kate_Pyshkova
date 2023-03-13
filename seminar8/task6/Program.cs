/* Задача 61: Показать треугольник Паскаля.
Сделать вывод в виде равнобедренного треугольника. */

Console.Clear();

Console.Write("Enter rows of Pascal triangle: ");
int rows = int.Parse(Console.ReadLine());
PrintTriangle(rows);

void PrintTriangle(int rows)
{
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j <= (rows - i); j++)
    {
      Console.Write("  ");
    }
    for (int k = 0; k <= i; k++)
    {
      Console.Write("   "); 
      Console.Write(factorial(i) / (factorial(k) * factorial(i - k)));
    }
    Console.WriteLine();
  }
}

float GetFactorial(int n)
{
  float result = 1;
  for (int i = 1; i <= n; i++)
  {
    result *= i;
  }
  return result;
}