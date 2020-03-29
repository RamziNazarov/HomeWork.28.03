using System;

namespace HomeWork._28._03
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Введите длину прямоугольника: ");
            int dlinaPU = int.Parse(Console.ReadLine());
            System.Console.Write("Введите высоту прямоугольника: ");
            int shrinaPU = int.Parse(Console.ReadLine());
            for(int i =0; i < shrinaPU;i++)
            {
                for (int j = 0; j < dlinaPU; j++)
                {
                    if(j > 0 && j < dlinaPU-1 && i != 0 && i != shrinaPU-1)
                    {
                        System.Console.Write(" ");
                    }
                    else{
                        System.Console.Write("*");
                    }
                    
                }
                Console.WriteLine();
            }
            System.Console.WriteLine();

            System.Console.Write("Введите длину треугольника: ");
            int dlinaTreugolnika = int.Parse(Console.ReadLine());
            int s = 1;
            for(int i = 0; i < dlinaTreugolnika; i++)
            {
                for(int j = 0; j < s;j++)
                {
                    if(j > 0 && j < s-1 && i != 0 && i != dlinaTreugolnika-1)
                    {
                        System.Console.Write(" ");
                    }
                    else
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
                s++;
            }
            System.Console.WriteLine();
            
            System.Console.WriteLine();
            System.Console.Write("Введите длину треугольника: ");
            int dlina = int.Parse(Console.ReadLine());
            int n = dlina-1;
            int l = dlina-1;
            for(int i = 0;i < dlina;i++)
            {
                for(int j = 0; j < (dlina -1)*2;j++)
                {
                    if(j == n)
                    {
                    System.Console.Write("*");
                    }
                    if(j == l && l != n)
                    {
                        System.Console.Write("*");
                    }
                    if(j != n && j != l && i != dlina-1)
                    {
                        System.Console.Write(" ");
                    }
                    if(i == dlina-1)
                    {
                        System.Console.Write("*");
                    }
                }
                n++;
                l--;
                System.Console.WriteLine();
            }
            System.Console.WriteLine();

            Console.Write("Введите высоту ромба: ");
            int dlinaRomba = int.Parse(Console.ReadLine());
            dlinaRomba = (dlinaRomba%2==1)?dlinaRomba:dlinaRomba+1;
            int k = (dlinaRomba+1)/2;
            int p = (dlinaRomba+1)/2;
            for(int i = 0; i < dlinaRomba; i++)
            {
                for(int j = 0; j < dlinaRomba+1;j++)
                {
                    if(j == k && (i < dlinaRomba/2+1 || i>dlinaRomba/2))
                    {
                        System.Console.Write("*");
                    }
                    if(j == p && (i < dlinaRomba/2+1 || i > dlinaRomba/2) && k != p)
                    {
                        System.Console.Write("*");
                    }
                    if(j != k && j != p){
                        System.Console.Write(" ");
                    }
                }
                if(i < dlinaRomba/2){
                k--;
                p++;
                }
                else{
                    k++;
                    p--;
                }
                System.Console.WriteLine();
            }
            System.Console.Write("Введите число А: ");
            int a = int.Parse(Console.ReadLine());
            System.Console.Write("Введите число В: ");
            int b = int.Parse(Console.ReadLine());
            int summaVsexChisel = 0;
            for(int i = a+1; i < b;i++)
            {
                summaVsexChisel += i;
            }
            System.Console.Write($"Сумма всех числе расположенных между А и В = {summaVsexChisel}");
            System.Console.WriteLine();
            System.Console.WriteLine("Нечетные числа расположенные между А и В:");
            for(int i = a+1; i < b;i++)
            {
                if(i%2==1)
                {
                    System.Console.WriteLine(i);
                }
            }

            System.Console.Write("Введите процент Р: ");
            decimal p1 = decimal.Parse(Console.ReadLine());
            decimal nachalniyVklad = 1000;
            System.Console.WriteLine($"Начальная сумма вклада = {nachalniyVklad}");
            k = 0;
            for(;!(nachalniyVklad > 1100);)
            {
                nachalniyVklad += nachalniyVklad * p1/100;
                k++;
            }
            System.Console.WriteLine($"Размер вклада за {k} месяцев с {p1} процентным прибавлением в месяц = {Math.Round(nachalniyVklad,1)}");
            Console.ReadKey();
        }
    }
}
