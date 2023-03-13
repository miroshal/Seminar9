// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Prompt(string massege)
{
    System.Console.Write(massege);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int AckermanFunc(int m, int n)
{

    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermanFunc(m - 1, 1);
    else return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
}

int m = Prompt("Введи m: ");
int n = Prompt("Введи n: ");

System.Console.WriteLine();
System.Console.WriteLine(AckermanFunc(m, n));