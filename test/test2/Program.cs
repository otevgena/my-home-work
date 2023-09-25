// Напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 1; i <= number; i++)
{
    result = result * i;
    Console.WriteLine(result);
}