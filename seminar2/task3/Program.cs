/* Напишите программу, которая принимает на вход цифру, обозначающую день недели,
 и проверяет, является ли этот день выходным.

  6 -> да
  7 -> да
  1 -> нет */

Console.Clear();

string[] week = new string[] {"Monday", "Thursday", "Wednesday", "Thuesday", "Friday", "Saturday", "Sunday"};
int days = week.Length;

Console.Write("Select a number from 1 to 7: ");
int day = int.Parse(Console.ReadLine());
if (day <= 5) 
{
  Console.WriteLine($"This is a weekday - {week[day-1]}");
}

else 
{
  Console.WriteLine($"This is a holiday - {week[day-1]}");
}
