
namespace Пианино2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Чтобы выбрать октаву нажмите клавиши F1, F2, F3 для выбора первой, второй, третьей октавы сообтветственно");
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                Console.SetCursorPosition(0, 1);
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.F1)
                {
                    Console.SetCursorPosition(0, 3);
                    FirstOk();
                }
                if (key1.Key == ConsoleKey.F2)
                {
                    Console.SetCursorPosition(0, 3);
                    SecondtOk();
                }
                if (key1.Key == ConsoleKey.F3)
                {
                    Console.SetCursorPosition(0, 3);
                    ThreadOktava();
                }
                if (key1.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (key.Key != ConsoleKey.F16);
        }
        static void FirstOk()
        {
            Console.WriteLine("AMOGUS");
            Thread.Sleep(1600);
            Console.Clear();
            Console.WriteLine("Чтобы выбрать октаву нажмите клавиши F1, F2, F3 для выбора первой, второй, третьей октавы сообтветственно.");
            Console.WriteLine("До |До# |Ре |Ре# |Ми |Фа |Фа# |Сoль |Сoль# |Ля |Ля# |Си      -Первая октава-");
            Console.WriteLine("A  |W   |S  |E   |D  |F  |T   |G    |Y     |H  |U   |J");
            ConsoleKeyInfo key1 = Console.ReadKey();
            int[] firstOctave = new int[] { 261, 277, 293, 311, 329, 349, 369, 391, 415, 440, 466, 493 };
            do
            {
                Console.SetCursorPosition(0, 3);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.A)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[0], 200);
                }
                if (key.Key == ConsoleKey.W)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[1], 200);
                }
                if (key.Key == ConsoleKey.S)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[2], 200);
                }
                if (key.Key == ConsoleKey.E)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[3], 200);
                }
                if (key.Key == ConsoleKey.D)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[4], 200);
                }
                if (key.Key == ConsoleKey.F)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[5], 200);
                }
                if (key.Key == ConsoleKey.T)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[6], 200);
                }
                if (key.Key == ConsoleKey.G)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[7], 200);
                }
                if (key.Key == ConsoleKey.Y)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[8], 200);
                }
                if (key.Key == ConsoleKey.H)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[9], 200);
                }
                if (key.Key == ConsoleKey.U)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[10], 200);
                }
                if (key.Key == ConsoleKey.J)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(firstOctave[11], 200);
                }
                if (key.Key == ConsoleKey.F2)
                {
                    SecondtOk();
                }
                if (key.Key == ConsoleKey.F3)
                {
                    ThreadOktava();
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (key1.Key != ConsoleKey.F16);
            return;
        }
        static void SecondtOk()
        {
            Console.WriteLine("УльраМегаABOBUS");
            Thread.Sleep(1600);
            Console.Clear();
            Console.WriteLine("Чтобы выбрать октаву нажмите клавиши F1, F2, F3 для выбора первой, второй, третьей октавы сообтветственно.");
            Console.WriteLine("До |До# |Ре |Ре# |Ми |Фа |Фа# |Сoль |Сoль# |Ля |Ля# |Си      -Вторая октава-");
            Console.WriteLine("A  |W   |S  |E   |D  |F  |T   |G    |Y     |H  |U   |J");
            ConsoleKeyInfo key = Console.ReadKey();
            int[] secondOctave = new int[] { 523, 554, 587, 622, 659, 698, 739, 783, 830, 880, 932, 987};
            do
            {
                Console.SetCursorPosition(0, 3);
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.A)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[0], 200);
                }
                if (key1.Key == ConsoleKey.W)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[1], 200);
                }
                if (key1.Key == ConsoleKey.S)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[2], 200);
                }
                if (key1.Key == ConsoleKey.E)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[3], 200);
                }
                if (key1.Key == ConsoleKey.D)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[4], 200);
                }
                if (key1.Key == ConsoleKey.F)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[5], 200);
                }
                if (key1.Key == ConsoleKey.T)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[6], 200);
                }
                if (key1.Key == ConsoleKey.G)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[7], 200);
                }
                if (key1.Key == ConsoleKey.Y)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[8], 200);
                }
                if (key1.Key == ConsoleKey.H)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[9], 200);
                }
                if (key1.Key == ConsoleKey.U)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[10], 200);
                }
                if (key1.Key == ConsoleKey.J)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(secondOctave[11], 200);
                }
                if (key1.Key == ConsoleKey.F1)
                {
                    Console.SetCursorPosition(0, 4);
                    FirstOk();
                }
                if (key1.Key == ConsoleKey.F3)
                {
                    Console.SetCursorPosition(0, 4);
                    ThreadOktava();
                }
                if (key1.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (key.Key != ConsoleKey.F16);
            return;
        }
        static void ThreadOktava() 
        {
            Console.WriteLine("Наконец третья октава");
            Thread.Sleep(1600);
            Console.Clear();
            Console.WriteLine("Чтобы выбрать октаву нажмите клавиши F1, F2, F3 для выбора первой, второй, третьей октавы сообтветственно.");
            Console.WriteLine("До |До# |Ре |Ре# |Ми |Фа |Фа# |Сoль |Сoль# |Ля |Ля# |Си      -Третья октава-");
            Console.WriteLine("A  |W   |S  |E   |D  |F  |T   |G    |Y     |H  |U   |J");
            ConsoleKeyInfo key = Console.ReadKey();
            int[] TO = new int[] { 1046, 1108, 1174, 1244, 1318, 1396, 1479, 1567, 1661, 1760, 1864, 1975 };
            do
            {
                Console.SetCursorPosition(0, 3);
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.A)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[0], 200);
                }
                if (key1.Key == ConsoleKey.W)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[1], 200);
                }
                if (key1.Key == ConsoleKey.S)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[2], 200);
                }
                if (key1.Key == ConsoleKey.E)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[3], 200);
                }
                if (key1.Key == ConsoleKey.D)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[4], 200);
                }
                if (key1.Key == ConsoleKey.F)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[5], 200);
                }
                if (key1.Key == ConsoleKey.T)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[6], 200);
                }
                if (key1.Key == ConsoleKey.G)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[7], 200);
                }
                if (key1.Key == ConsoleKey.Y)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[8], 200);
                }
                if (key1.Key == ConsoleKey.H)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[9], 200);
                }
                if (key1.Key == ConsoleKey.U)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[10], 200);
                }
                if (key1.Key == ConsoleKey.J)
                {
                    Console.SetCursorPosition(0, 3);
                    Console.Beep(TO[11], 200);
                }
                if (key1.Key == ConsoleKey.F1)
                {
                    FirstOk();
                }
                if (key1.Key == ConsoleKey.F2)
                {
                    SecondtOk();
                }
                if (key1.Key == ConsoleKey.Escape)
                {
                    return;
                }
            } while (key.Key != ConsoleKey.F16);
            return;
        }
    }   
}