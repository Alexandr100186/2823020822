// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. Решить без использования строк.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > -1000 && num < -99 || num < 1000 && num > 99)
{
    int result = (num / 10)- (num / 100 * 10);
    int x = Math.Abs(result);
    Console.WriteLine($": {x}");
}
else
{
    Console.WriteLine("Введено не верное значение");
}