/*int a = Convert.ToInt32(Console.ReadLine());#ПОЧЕМУ НЕ РАБОТАЕТ?
var numbers = new int[] { 1,a };

var result = numbers[1..a];

Console.WriteLine(result);
Console.ReadLine();*/
Console.WriteLine("1-Игра угадай число\n2-Таблица умножения\n3-Вывод делителей числа\n4-выход\nВыберите опперацию :");
int a = Convert.ToInt32(Console.ReadLine());
do
{
    if (a==1)
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
        Console.WriteLine("1-Игра угадай число\n2-Таблица умножения\n3-Вывод делителей числа\n4-выход\nВыберите опперацию :");
        int k = Convert.ToInt32(Console.ReadLine());
        if (k == 2) 
        {
            Console.WriteLine(a = 2);
        }
        if (k == 3)
        {
            Console.WriteLine(a = 3);
        }
        if (k == 4)
        {
            Console.WriteLine(a = 4);
        }
    }
    if (a==2)
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
        Console.WriteLine("1-Игра угадай число\n2-Таблица умножения\n3-Вывод делителей числа\n4-выход\nВыберите опперацию :");
        int z = Convert.ToInt32(Console.ReadLine());
        if (z == 2)
        {
            Console.WriteLine(a = 2);
        }
        if (z == 3)
        {
            Console.WriteLine(a = 3);
        }
        if (z == 4)
        {
            Console.WriteLine(a = 4);
        }
    }
    if (a==3)
    {
        Console.Write("Введи число ");
        int x = int.Parse(Console.ReadLine());
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                Console.Write("\n" + i);
            }
        }
        Console.WriteLine("\n1-Игра угадай число\n2-Таблица умножения\n3-Вывод делителей числа\n4-выход\nВыберите опперацию :");
        int p = Convert.ToInt32(Console.ReadLine());
        if (p == 2)
        {
            Console.WriteLine(a = 2);
        }
        if (p == 3)
        {
            Console.WriteLine(a = 3);
        }
        if (p == 4)
        {
            Console.WriteLine(a = 4);
        }
    }
} while (a != 4);


