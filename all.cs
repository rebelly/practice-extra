using System;
public class Program
{
    static string period(int m, int n)
    {
        string remain = "";
        if ((m / n) * n == m) {
            return "0";
        }
        else
        {

            m -= m / n * n;
            for (int i = 0; i <= 50; i++)
            {

                if ((m / n) == 0)

                {
                    if (m * 10 / n > 0)
                    {
                        m *= 10;
                        continue;
                    }
                    remain += "0";
                    m *= 10;
                }

                else
                {
                    remain += $"{m / n}";
                    m -= (m / n) * n;
                }


            }
            return remain;
        }
    }
    static void fath_son(int g_f, int g_s)
    {
        int fath_w= 0;
        int son_w = 0;
        for (int i = 300; i <= 400; i++)
        {
            if (g_f % i == 0 && g_s%i == 0)
            {
                fath_w = g_f / i;
                son_w = g_s / i;
            }
        }
        Console.WriteLine($"{fath_w} {son_w}");
    }
    static int nod(int a, int b)
    {
        while (a != b)
        {
            if (a > b)
            {
                a -= b;
            }
            else
            {
                b -= a;
            }
        }
        return a;
    }
    static void frac(int a, int b, int c , int d)
    {
        int  den = (a * d + c * b) ;
        int numer = d * b;
        int NOD= nod(den, numer);
        den /= NOD;
        numer /= NOD;

        Console.WriteLine($"{den}/{numer}");
    }

    public static void Main()
    {
        /*
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Остаток от деления числа {m} на {n} равен {period(m, n)}");
       */
        /*
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        frac(a, b, c, d);
        
        */
        /*
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        fath_son(m,n);
          */
    }
}
