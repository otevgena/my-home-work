﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.WriteLine("Введите число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (0 < i)
{
int num = i % 10;
i = i /10;
sum = sum + num;    
}
Console.WriteLine($"сумма цифр в числе равна {sum}");