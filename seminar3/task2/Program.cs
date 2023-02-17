/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

 A (3,6,8); B (2,1,-7), -> 15.84

 A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();

Console.Write("Enter x1: ");
double x1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter y1: ");
double y1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter z1: ");
double z1 = double.Parse(Console.ReadLine()!);
Console.Write("Enter x2: ");
double x2 = double.Parse(Console.ReadLine()!);
Console.Write("Enter y2: ");
double y2 = double.Parse(Console.ReadLine()!);
Console.Write("Enter z2: ");
double z2 = double.Parse(Console.ReadLine()!);

double result = Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2));
Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {result:f2}))");
