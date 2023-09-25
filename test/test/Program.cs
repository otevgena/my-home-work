// напишите программу которая на вход принимает число (А), а на выходе показывает сумму чисел от 1 до A
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;

    for (int i= 1; i <= number; i++)
{
        result += i;
}

Console.WriteLine($"Сумма числа {number} равна {result}");