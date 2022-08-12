// 9. Напишите программу, которая 
// 1.выводит случайное число из отрезка [10, 99]
// 2.показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99 + 1);
// Console.WriteLine($"Случайное число из диапазона 10 - 99 =>{number}");

int firstDigit = number / 10;
int secongDigit = number % 10;

// if(firstDigit == secongDigit) Console.WriteLine("Цифры равны");
// else if(firstDigit > secongDigit) Console.WriteLine($"Наибольшая цифра числа {number} => {firstDigit}");
// else Console.WriteLine($"Наибольшая цифра числа {number} => {secongDigit}");

//Либо решение через тернальный оператор преобразуя в тип строка
// string result = firstDigit == secongDigit ? "Цифры равны"
// // // если firstDigit равен secongDigit выводим сообщение "Цифры равны"
//  : firstDigit > secongDigit ? firstDigit.ToString() : secongDigit.ToString();
// // // если firstDigit больше secongDigit, тогда мы записываем в result - firstDigit, иначе secongDigit
// Console.WriteLine($"Наибольшая цифра числа {number} => {result}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secongDigit = num % 10;
    if (firstDigit == secongDigit)return 0;
    return firstDigit > secongDigit ? firstDigit : secongDigit;
}

int result = MaxDigit(number);
// int result1 = MaxDigit(88);
// int result2 = MaxDigit(98);
string res = result == 0 ? "Цифры равны" : result.ToString();
Console.WriteLine($"Наибольшая цифра числа {number} => {res}");
// Console.WriteLine($"Наибольшая цифра числа {number} => {res1}");
// Console.WriteLine($"Наибольшая цифра числа {number} => {res2}");
