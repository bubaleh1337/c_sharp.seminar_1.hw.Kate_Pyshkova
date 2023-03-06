﻿/* Доп **
Игра «Жизнь» была придумана английским математиком 
Джоном Конвейем в 1970 году.
Впервые описание этой игры опубликовано в октябрьском 
выпуске (1970) журнала Scientic American,
в рубрике «Математические игры» Мартина Гарднера.

Место действия этой игры – «вселенная» – это 
размеченная на клетки поверхность.
Каждая клетка на этой поверхности может находиться в 
двух состояниях: быть живой или быть мертвой.
Клетка имеет восемь соседей. Распределение живых клеток 
в начале игры называется первым поколением.
Каждое следующее поколение рассчитывается на основе 
предыдущего по таким правилам:

1)пустая(мертвая) клетка с ровно тремя живыми 
клетками-соседями оживает;
2)если у живой клетки есть две или три живые соседки, 
то эта клетка продолжает жить;
в противном случае (если соседок меньше двух или больше 
трех)
клетка умирает(от «одиночества» или от 
«перенаселенности»).
В этой задаче рассматривается игра «Жизнь» на торе.
Представим себе прямоугольник размером n строк 
на m столбцов.
Для того, чтобы превратить его в тор мысленно «склеим» 
его верхнюю сторону с нижней, а левую с правой.

Таким образом, у каждой клетки, даже если она раньше 
находилась на границе прямоугольника,
теперь есть ровно восемь соседей.

Ваша задача состоит в том, чтобы найти конфигурацию 
клеток, которая будет через k поколений от заданного.

n m k(4 ≤ n, m ≤ 100; 0 ≤ k ≤ 100).
5 5 1
++...
..++.
.+...
..+..
...+.

.+.++
+.+..
.+.+.
..+..
.++..

5 5 5
++...
..++.
.+...
..+..
...+.

.+++.
.+...
.+...
..++.
.....

4 7 5
.+.+.+.
+.+.+.+
.+.+.+.
+.+.+.+

.......
.......
.......
....... */

Console.Clear();
int n_row = GetRowsColumns($"Enter rows of the life field: ");
int m_columns = GetRowsColumns($"Enter columns of the life field: ");
//int k_generation = 1;
char[,] lifeField = GetLifeField(n_row, m_columns);
PrintLifeField(lifeField);

int GetRowsColumns(string message)
{
  Console.Write(message);
  int num = int.Parse(Console.ReadLine()!);
  return num;
}

char[,] GetLifeField(int rows, int columns)
{
  char[,] lifeField = new char[rows, columns];
  Random rnd = new Random();
  string chars = "*.";

  for (int i = 0; i < lifeField.GetLength(0); i++)
  {
    for (int j = 0; j < lifeField.GetLength(1); j++)
    {
      int x = rnd.Next(2);
      lifeField[i, j] += chars[x];
    }
  }
  return lifeField;
}

void PrintLifeField(char[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
  }
}

int GameOfLife(char[,] lifeField, int rows, int m_columns)
{

}
