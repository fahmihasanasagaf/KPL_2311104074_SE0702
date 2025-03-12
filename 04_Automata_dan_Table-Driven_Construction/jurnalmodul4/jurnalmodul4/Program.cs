using System;

namespace jurnalmodul4
{
    class Program
    {
        static void Main(string[] args)
        {
            PosisiKarakterGame karakter = new PosisiKarakterGame();

            while (true)
            {
                Console.Write("Tekan tombol (W/S/X, Q untuk keluar): ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == 'q' || input == 'Q')
                {
                    Console.WriteLine("Game selesai.");
                    break;
                }
                else if (input == 'w' || input == 'W')
                {
                    karakter.TombolW();
                }
                else if (input == 's' || input == 'S')
                {
                    karakter.TombolS();
                }
                else if (input == 'x' || input == 'X')
                {
                    karakter.TombolX();
                }
            }
        }
    }
}
