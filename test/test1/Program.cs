// Напишите программу, которая на вход принимает число выдает количество цифр в ней
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (number > 0)
// {
// number = number / 10;
// count++;
// }

// Console.WriteLine($"Количество цифр в числе равен(а): {count}");

// Способ через string

Console.WriteLine("Введите число");

int Count(int number)
{
    return number.ToString().Length;
}

int number = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine($"В числе {number} количество цифр равна: {Count(number)}");