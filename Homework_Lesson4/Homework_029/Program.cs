// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


using System; 
 
class Program 
{ 
    static void Main() 
    { 
        // Создаем массив из 8 элементов типа int 
        int[] numbers = new int[8]; 
 
        for (int i = 0; i < numbers.Length; i++) 
        { 
            numbers[i] = i + 1; 
        } 
 
        Console.WriteLine("Элементы массива:"); 
        foreach (int number in numbers) 
        { 
            Console.WriteLine(number); 
        } 
        Console.ReadKey(); 
    } 
}