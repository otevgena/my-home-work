﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if ((a > b) & (a > c)) { Console.WriteLine($"Наибольшее число {a}"); }
else if ((b > a) & (b > c)) { Console.WriteLine($"Наибольшее число {b}"); }
else { Console.WriteLine($"Наибольшее число {c}"); }

