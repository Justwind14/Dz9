// Task64();
Task66();
// Task68();

void Task64()
{   // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, который 
    // выведет все натуральные числа кратные 3-ём в промежутке от M до N.

    Console.WriteLine("Введите натуральное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (m < 0 || n < 0)
    {
        Console.WriteLine("Введите НАТУРАЛЬНОЕ(больше нуля) число: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите еще одно НАТУРАЛЬНОЕ(больше нуля) число: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Числа кратные трём в вышеуказанном промежутке: ");
    if (m < n) { DivOfNumber1(m, n);}
    else {DivOfNumber2(m, n);}
}


void DivOfNumber1(int m, int n)
{
    if (m >= n + 1)
    {
        return;
    }
    if (m % 3 == 0)
    {
        Console.Write($"{m} ");
        m += 3;
    }
    else
    {
        m++;
    }
    DivOfNumber1(m, n);
}

void DivOfNumber2(int m, int n)
{
    if (m <= n - 1)
    {
        return;
    }
    if (m % 3 == 0)
    {
        Console.Write($"{m} ");
        m -= 3;
    }
    else
    {
        m--;
    }
    DivOfNumber2(m, n);
}



void Task66()
{
    // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Введите натуральное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (m < 0 || n < 0)
    {
        Console.WriteLine("Введите НАТУРАЛЬНОЕ(больше нуля) число: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите еще одно НАТУРАЛЬНОЕ(больше нуля) число: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    if (m < n){Console.WriteLine(SummNaturalElements1(m,n));}
    else {Console.WriteLine(SummNaturalElements2(m,n));}
}

int SummNaturalElements1(int m, int n, int summ = 0)
{
    if (m == n + 1)
    {
        return summ;
    }
    summ = summ + m;
    m++;
    return SummNaturalElements1(m, n, summ);
}
int SummNaturalElements2(int m, int n, int summ = 0)
{
    if (m == n - 1)
    {
        return summ;
    }
    summ = summ + m;
    m--;
    return SummNaturalElements2(m, n, summ);
}



void Task68()
{
    // Задача 68: Напишите программу вычисления функции Аккермана
    //  с помощью рекурсии. Даны два неотрицательных числа m и n.
    Console.WriteLine("Введите натуральное число: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно натуральное число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    while (m < 0 || n < 0)
    {
        Console.WriteLine("Введите НАТУРАЛЬНОЕ(больше нуля) число: ");
        m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите еще одно НАТУРАЛЬНОЕ(больше нуля) число: ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(Ackermann(m, n));

}

int Ackermann(int m, int n)
{
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Ошибка, введите положительные числа!");
        return 0;
    }
    if (m == 0)
    {
        Console.WriteLine($"проходит по первому условию. n = {n}");
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        Console.WriteLine($"проходит по первому условию. m = {m}"); return Ackermann(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        Console.WriteLine($"проходит по первому условию. m = {m}, n = {n}");
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
    return Ackermann(n, m);
}