// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// 123456789 -> 3

Console.WriteLine("Напишите трехзначное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
if (stringNumber.Length > 2)
{
    Console.WriteLine($"Третьяя цифра числа {stringNumber[2]}");
}
else Console.WriteLine ("Нет третьей цифры");
