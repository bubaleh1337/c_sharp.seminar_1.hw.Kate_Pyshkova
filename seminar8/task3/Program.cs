/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();
int[,] matrixA = GetMatrix();
int[,] matrixB = GetMatrix();
PrintMatrix(matrixA, matrixB);
MultiplyMatrix(matrixA, matrixB);
Console.WriteLine();
PrintResultMatrix(MultiplyMatrix(matrixA, matrixB));

int[,] GetMatrix()
{
  int[,] matrix = new int[2, 2];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(1, 10);
    }
  }
  return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
  int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
      result[i, j] = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        result[i, j] += matrix1[i, k] * matrix2[k, j];
      }
    }
  }
  return result;
}

void PrintMatrix(int[,] a, int[,] b)
{
  for (int i = 0; i < a.GetLength(0); i++)
  {
    for (int j = 0; j < (a.GetLength(1) + b.GetLength(1))+1; j++)
    {
      if (j < a.GetLength(1)) Console.Write(a[i, j]);
      else if (j == a.GetLength(1)) Console.Write(" | ");
      else { Console.Write(b[i, j - a.GetLength(1)-1]); }
    }
    Console.WriteLine();
  }
}

void PrintResultMatrix(int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      if (j == resultMatrix.GetLength(1) / 2) Console.Write(" ", -2);
      Console.Write(resultMatrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}