// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < -99 || num > 99)
{
    int result = ((num / 100) % 10);
    int x = Math.Abs(result);
    Console.WriteLine($": {x}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}