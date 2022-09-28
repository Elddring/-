namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            do
            {
                Console.WriteLine("1-Игра угадай число\n2-Таблица умножения\n3-Вывод делителей числа\n4-выход\nВыберите опперацию :");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 1)
                {
                    guessthenumber();
                }
                if (h == 2)
                {
                    multiplicationtable();
                }
                if (h==3)
                {
                    DeliteliChisla();

                }
                if (h == 4)
                {
                    Exit();
                    break;
                }
            } while (a != 4);
           
        }

        static void guessthenumber() 
        {
            Random random = new Random();
            int n = random.Next(0, 100) + 1;
            string chislo;

            Console.WriteLine("Угадайте число от 1 до 100");
            do
            {
                Console.Write("Ваш вариант: ");
                chislo = Console.ReadLine();

                if (int.Parse(chislo) < n)
                    Console.WriteLine("Задуманное число больше");
                if (int.Parse(chislo) > n)
                    Console.WriteLine("Задуманное число меньше");
            }
            while (int.Parse(chislo) != n);
            Console.WriteLine("Вы угадали");
        }
        static void multiplicationtable() 
        {
            Console.WriteLine("Таблица умножения");
            int x = 10;
            int y = 1;
            int[,] mat = new int[x, y];
            Console.WriteLine("---------------------------------------------------------------------------------");
            for (int i = 1; i < mat.Length; i++)
            {
                Console.WriteLine("|");
                for (int j = 1; j < x; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("\t|");
            }
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        static void DeliteliChisla() 
        {
            Console.WriteLine("Введи число ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    Console.Write("\n" + i);
                }
            }
           
        }

        static void Exit() 
        {
            Console.WriteLine("Вы вышли лол");
        }

    }

}