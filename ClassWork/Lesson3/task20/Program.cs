// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату x для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2 - y1)*(y2 - y1));
Console.WriteLine("Расстояние между точками равно: {0: #.##}", result);