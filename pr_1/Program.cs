/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


int N = GetNumberFromUser("Введите число N: ");
Console.WriteLine($"числа от {N} до 1 -> {FromNToOne(N,1)}");

int GetNumberFromUser (string message) 
{
    while(true) 
    {

        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int number);
        while(isCorrect)
            return number;
            Console.WriteLine("Ошибка ввода!");
    }
}

string FromNToOne (int start, int finish) 
{
    if (start == finish) return start.ToString();

    return (start + ", " + FromNToOne(start-1,finish));
}