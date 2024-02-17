using System;

class Program
{
    static void Main()
    {
        int N = 5;
        int i = 1;
        int F = 1;

        while (i <= N)
        {
            F = F * i;
            i = i + 1;
        }

        if (i > N)
        {
            Console.WriteLine($"Факториал числа {N} равен {F}");
        }
        else
        {
            Console.WriteLine("Ошибка: i > N");
        }
    }
}
