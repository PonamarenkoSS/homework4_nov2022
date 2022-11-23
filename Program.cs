// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число, которое хотите возвести в степень:");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите степень, в которую хотите возвести введённое ранее число:");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{A} в степени {B} равно {Pow(A,B)}");

// int Pow(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i<=B; i++)
//     {
//      result = result*a;
//     }
//     return result;
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число:");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма цифр числа {A} составляет {Count(A)}");

// int Count(int N)
// {
//     int i = 0;
//     while (N>0)
//     {
//         int A=N%10;
//         i = i+A;
//         N=N/10;
//     }
//     return i;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

// int[] MakeArray()
// {
//     int[] array = new int[8];
//     for (int i=0; i<8; i++)
//     {
//         array[i] = new Random().Next(10, 1000);
//     }
//     return array;
// }
// int[] ARRAY = MakeArray();
// Console.WriteLine($"Массив: [{String.Join(",", ARRAY)}]");
