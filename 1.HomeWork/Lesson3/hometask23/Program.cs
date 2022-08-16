// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите значение: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
if (num > 0)
{
    while (i <= num)
    {
        int q = i * i * i;
        Console.WriteLine($"{i}\t{q}");
        i++;
    }
}
else
{
    Console.WriteLine("Введите значение больше 0!");
}