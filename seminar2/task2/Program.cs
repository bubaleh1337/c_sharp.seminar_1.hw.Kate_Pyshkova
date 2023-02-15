 /* Напишите программу, которая выводит третью цифру заданного числа или 
 сообщает, что третьей цифры нет.

    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 */

Console.Clear();

int random = new Random().Next(1, 10000); // 5684, 5, 55, 654
Console.WriteLine($"Our random number is {random}");
while (random / 10 % 10) 
{
  Console.WriteLine(random);
}

