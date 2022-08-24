// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void ShowFibonacci(int num)
{
int num1 = 0;
int num2 = 1;

Console.Write(num1+" "+num2+" ");

for (int i = 2; i < num; i++)
{
int temp = num1 + num2;
num1 = num2;
num2 = temp;
Console.Write(temp+" ");
}
Console.WriteLine();
}

ShowFibonacci(number);

// // фибоначи, ввести число
// Console.Write("Введите число:");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr=new int[size];
// arr[0]=0;
// arr[1]=1;
// for (int i = 2; i < size; i++)
// {
// arr[i]=arr[i-1]+arr[i-2];
// }

// void PrintArray(int[] array)
// {
// Console.Write("[");
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write($"{array[i]}");
// if (i != array.Length - 1) Console.Write(",");
// }
// Console.Write("]");
// Console.WriteLine();
// }
// PrintArray(arr);