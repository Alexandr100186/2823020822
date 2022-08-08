// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(System.Console.ReadLine());
// int count = 1;
// Console.WriteLine("Чётные числа от 1 до " + N);
// while (count <= N);
// {
//     if(count % 2 == 0);
//     {
//         Console.Write(count );
//     }
//     count++;
// }

//  int i = 1;
//             bool not = true;

//             Console.WriteLine("Введите число:");
//             num = Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("Чётные числа от 1 до " + num);
//             while (i <= num)
//             {
//                 if (i % 2 != 1)
//                 {
//                     Console.Write(i + ", ");
//                     not = false;
//                 }
//                 i++;
//             }

//             if (not)
//             {
//                 Console.WriteLine("Нет чётных чисел!");
//             }
//             break;

//         default;
//             begin = false;
//             break;


// Console.WriteLine("Введите длину: ");
// int n = int.Parse(Console.ReadLine());
    
// for (int i = 1; i <= n; i++)
//     if (i % 2 == 0)
//         Console.WriteLine(i);


        int num = Convert.ToInt32(Console.ReadLine());
        int res = 1;
       
        if (res == 1)

        {
         res += 1;
        }

        while (res <= num)

        {
            Console.WriteLine(res);
            res += 2;
        }

