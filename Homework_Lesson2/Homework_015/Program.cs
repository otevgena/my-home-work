// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите день недели");
int week = Convert.ToInt32(Console.ReadLine());
if (week > 5 & week < 8)
{
    Console.WriteLine("Выходной день");
}
else if (week > 0 & week < 6)
{
    Console.WriteLine("Рабочий день");
}
else Console.WriteLine("Нет такого дня недели");