// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int result = 0;
// int mult = 1;
// while(number > 0)
// {
// result += number % 2 * mult;
// number = number / 2;
// mult *= 10;
// }

// Console.WriteLine(result);

//через рекурсию
void DecToBin(int num)
{
    if(num == 0) return;
    DecToBin(num / 2);
    Console.Write(num % 2);
}
DecToBin(number);