while (true)
{
    int[] octave1 = new int[] { 130,  138,  146,  155,  164,  174,  185,  196,  207,  220,  233,  246 };
    int[] octave2 = new int[] { 261,  277,  293,  311,  329,  349,  370,  392,  415,  440,  466,  493 };
    ConsoleKeyInfo key = Console.ReadKey();
 if (key.Key == ConsoleKey.A)
    {      
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[0]);
            }
        }
    }
    if (key.Key == ConsoleKey.S)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[1]);
            }
        }
    }
    if (key.Key == ConsoleKey.D)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[2]);
            }
        }
    }
    if (key.Key == ConsoleKey.F)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[3]);
            }
        }
    }
    if (key.Key == ConsoleKey.G)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[4]);
            }
        }
    }
    if (key.Key == ConsoleKey.H)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[5]);
            }
        }
    }
    if (key.Key == ConsoleKey.J)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[6]);
            }
        }
    }
    if (key.Key == ConsoleKey.K)
    {
        x(octave1);
        static void x(int[] oct)
        {
            {
                sound(oct[7]);
            }
        }
    }
    if (key.Key == ConsoleKey.Q)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[0]);
            }
        }
    }
    if (key.Key == ConsoleKey.W)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[1]);
            }
        }
    }
    if (key.Key == ConsoleKey.E)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[2]);
            }
        }
    }
    if (key.Key == ConsoleKey.R)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[3]);
            }
        }
    }
    if (key.Key == ConsoleKey.T)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[4]);
            }
        }
    }
    if (key.Key == ConsoleKey.Y)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[5]);
            }
        }
    }
    if (key.Key == ConsoleKey.U)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[6]);
            }
        }
    }
    if (key.Key == ConsoleKey.I)
    {
        x(octave2);
        static void x(int[] oct)
        {
            {
                soun(oct[7]);
            }
        }
    }
    static void sound(int octave1)
    {
        Console.Beep(octave1, 250);
    }
    static void soun(int octave2)
    {
        Console.Beep(octave2, 250);
    }
}



}

