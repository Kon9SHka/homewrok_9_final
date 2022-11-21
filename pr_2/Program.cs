/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = GetNumberFromUser("Введите число M: ");
int N = GetNumberFromUser("Введите число N: ");

if (M<N) 
{
    Console.WriteLine($"Сумма чисел от {M} до {N} -> {FromNToM(M,N)}");
}
else 
{
    Console.WriteLine($"Сумма чисел от {N} до {M} -> {FromNToM(N,M)}");
}

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

int FromNToM (int start, int finish) 

{
    if (start == finish) 
    {
        return start;
    }
    return (start + FromNToM(start+1,finish));
}