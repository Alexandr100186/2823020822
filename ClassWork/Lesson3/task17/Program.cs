// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

// Console.WriteLine("Введите координаты точки: ");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)Console.WriteLine("Первая четверть");
// else if (x < 0 && y > 0)Console.WriteLine("Вторая четверть");
// else if (x < 0 && y < 0)Console.WriteLine("Третья четверть");
// else if (x > 0 && y < 0)Console.WriteLine("Четвертая четверть");
// else Console.WriteLine("Введены некорректные координаты");

string GetQuarter (int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Первая четверть";
    if (xc < 0 && yc > 0) return "Вторая четверть";
    if (xc < 0 && yc < 0) return "Третья четверть";
    if (xc > 0 && yc < 0) return "Четвертая четверть";
    return "Введены некорректные координаты";
}

// string result  = GetQuarter(x, y);
// string result2  = GetQuarter(8, -9);
// string result3  = GetQuarter(0, 2);
// Console.WriteLine(result);
// Console.WriteLine(result2);
// Console.WriteLine(result3);

int i = 0;
string[] arr = new string[4];
while (i < arr.Length)
{
    Console.WriteLine($"Введите координаты точки {i + 1}: ");
    Console.Write("X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Y: ");
    int y = Convert.ToInt32(Console.ReadLine()); 

    // arr[i] = GetQuarter(x, y); -Сохранение данных в массив(при этом необходимо еще реализовать их вывод)
    string res = GetQuarter(x, y);
    Console.WriteLine(res);
    i++;
}
