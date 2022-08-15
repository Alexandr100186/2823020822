// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string GetRange (int q)
{
    if (q == 1) return "x > 0 b y > 0";
    if (q == 2) return "x < 0 b y > 0";
    if (q == 3) return "x > 0 b y < 0";
    if (q == 4) return "x > 0 b y < 0";
    return "Введено некорректное значение";
}
string result = GetRange(quarter);
Console.WriteLine($"Диапазон координат точек в этой четверти: {result}");