// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.WriteLine("Введите проверяемое на палиндромность число: ");
int num = Convert.ToInt32(Console.ReadLine()), rev = 0, dig, n;

n = num;
while (num > 0)
{
    dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
    if (rev == n)
        break;
}
if (n == rev) Console.WriteLine("да");
else Console.WriteLine("Нет");