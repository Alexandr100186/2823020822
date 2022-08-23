// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int count = Convert.ToString(num).Length;
    int buf = 0;
    int sum = 0;

    for (int i = 0; i <= count; i++)
    {
        buf = num - num % 10;
        sum = sum + (num - buf);
        num = num / 10;
    }
    return sum;
}
if (num > 0)
{
    int result = SumNumbers(num);
    Console.WriteLine($"Сумма цифр в числе {num}: " + result);
}
else Console.WriteLine("Некорректный ввод.");