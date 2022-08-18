// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int multiply = 1;
for (int i = 1; i <= number; i++)
{
    multiply = multiply * i;
}
Console.WriteLine($"Произведение чисел от 1 до {number}: {multiply}");