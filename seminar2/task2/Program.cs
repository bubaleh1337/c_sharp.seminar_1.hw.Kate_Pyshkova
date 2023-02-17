 /* Напишите программу, которая выводит третью цифру заданного числа или 
 сообщает, что третьей цифры нет.

    645 -> 5
    78 -> третьей цифры нет
    32679 -> 6 */

Console.Clear();

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
// int random = new Random().Next(1, 10000); // 5684, 5, 55, 654
// Console.WriteLine($"Our random number is {random}");

if (number <= 99) 
{
    Console.WriteLine("Число меньше 100");
}
else {
    while(number > 1000) {
        number /= 10; // num = num / 10
        
    }
    Console.WriteLine(number%10);
}
