/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int M = GetNumberFromUser("Введите число M (не больше 3): ", 3);
int N = GetNumberFromUser("Введите число N (не больше 5): ", 5);
int accerman_result = AccermanFunction(M,N);
Console.WriteLine($"Результат функции Аккермана чисел ({M},{N}) -> {accerman_result}");


int GetNumberFromUser (string message,int max) 
{
    while(true) 
    {

        Console.Write(message);
        bool isCorrect = (int.TryParse(Console.ReadLine(), out int number) && number <= max);
        while(isCorrect)
            return number;
            Console.WriteLine("Ошибка ввода!");
    }
}

int AccermanFunction (int M, int N) 

{
    if (M == 0) 
    {
        return N + 1;
    }
    else if (M >0 && N ==0) 
    {
        return AccermanFunction(M-1,1);
    }
    else 
    {
        return AccermanFunction(M-1,AccermanFunction(M, N-1));
    }
}