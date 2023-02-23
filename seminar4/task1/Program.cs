/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Clear();
Console.Write("Enter number А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Enter number B: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{A}, {B} -> {GetStepen(A, B)} ");

double GetStepen(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}