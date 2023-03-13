// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int GetSum(int min, int max)
{
    if (min == max) return max;
    else return GetSum(min + 1, max) + min;
}

int n = Prompt("Введи первое число: ");
int m = Prompt("Введи последнее число: ");

System.Console.WriteLine(GetSum(n, m));
