// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int sum = 0;    //int sum = default;

// for (int i = 1; i <= num; i++)
// {
//     sum = sum + i;   //sum+=i
// }

// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

//Через метод:

int SumNumbers(int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
         sum = sum + i;
    }
    return sum;
}
if (num > 0)
{
    int result = SumNumbers(num);
    Console.WriteLine($"Сумма чисел от 1 до {num} = {result}");
}
else Console.WriteLine("Некорректный ввод.");