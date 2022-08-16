// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Console.Write("Введите проверяемое на палиндромность число: ");
// string? number = Console.ReadLine();

// void CheckingNumber(string number)
// {
//     if (number[0] == number[4] || number[1] == number[3])
//     {
//         Console.WriteLine($"{number} -> да");
//     }
//     else Console.WriteLine($"{number} -> нет");
// }

// if (number!.Length == 5)
// {
//     CheckingNumber(number);
// }
// else Console.WriteLine($"Введено некорректное значение");

Console.WriteLine("Введите проверяемое на палиндромность число: ");
int num = Convert.ToInt32(Console.ReadLine()), rev = 0, dig, n;

n = num;
while (num > 0)
{
    dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10; 
    if (rev == n)
    break ;
}
if (n == rev) Console.WriteLine("да");
else Console.WriteLine("Нет");