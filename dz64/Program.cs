// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void GetNum (int num)
{
    if (num  == 0) 
    {
        System.Console.Write($"\b\b");
        System.Console.WriteLine();
        return;
    }
    else if (num < 0) 
    {
        Console.Write($"{num} не натуральное число! \n");
        GetNum (Prompt("Введи N еще раз: "));
        return; 
    }
    Console.Write($"{num}, ");
    GetNum(num - 1);
}

int n = Prompt("Введи N: ");
GetNum(n);
