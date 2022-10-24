namespace ConsoleApp7
{
    internal class Program
    {
        static int[] smenaoct(int octave)
        {
            if (octave == 1)
                return new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000, 1100, 1200 };
            else
                return new int[] { 1100, 1200, 1300, 1400, 1500, 1600, 1700, 1800, 1900, 2000, 2100, 22000 };
        }
        static void sound(int octave)
        {
            Console.Beep(octave, 200);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("          ");
            int[] octave = smenaoct(1);
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.F1)
                {
                    octave = smenaoct(1);
                }
                if (key.Key == ConsoleKey.F2)
                {
                    octave = smenaoct(2);
                }
                if (key.Key == ConsoleKey.A)
                {
                    sound(octave[0]);
                }
                if (key.Key == ConsoleKey.S)
                {
                    sound(octave[1]);
                }
                if (key.Key == ConsoleKey.D)
                {
                    sound(octave[2]);
                }
                if (key.Key == ConsoleKey.R)
                {
                    sound(octave[3]);
                }
                if (key.Key == ConsoleKey.F)
                {
                    sound(octave[4]);
                }
                if (key.Key == ConsoleKey.G)
                {
                    sound(octave[5]);
                }
                if (key.Key == ConsoleKey.H)
                {
                    sound(octave[6]);
                }
                if (key.Key == ConsoleKey.U)
                {
                    sound(octave[7]);
                }
                if (key.Key == ConsoleKey.J)
                {
                    sound(octave[8]);
                }
                if (key.Key == ConsoleKey.K)
                {
                    sound(octave[9]);
                }
                if (key.Key == ConsoleKey.L)
                {
                    sound(octave[10]);
                }
                if (key.Key == ConsoleKey.P)
                {
                    sound(octave[11]);
                }
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }
}
