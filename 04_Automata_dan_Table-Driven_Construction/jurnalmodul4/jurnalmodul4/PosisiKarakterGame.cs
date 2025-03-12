using System;

namespace jurnalmodul4
{
    class PosisiKarakterGame
    {
        // Enum untuk mendefinisikan state karakter
        public enum State
        {
            Berdiri,
            Jongkok,
            Tengkurap,
            Terbang
        }

        // State awal karakter
        private State currentState;

        public PosisiKarakterGame()
        {
            currentState = State.Berdiri;
            Console.WriteLine("Karakter mulai dalam posisi: Berdiri");
        }

        // Method untuk mengubah state berdasarkan tombol yang ditekan
        public void TombolW()
        {
            if (currentState == State.Berdiri)
            {
                currentState = State.Terbang;
                Console.WriteLine("Posisi take off (Terbang)");
            }
            else if (currentState == State.Jongkok)
            {
                currentState = State.Berdiri;
                Console.WriteLine("Karakter berdiri dari jongkok");
            }
            else if (currentState == State.Tengkurap)
            {
                currentState = State.Jongkok;
                Console.WriteLine("Karakter jongkok dari tengkurap");
            }
        }

        public void TombolS()
        {
            if (currentState == State.Berdiri)
            {
                currentState = State.Jongkok;
                Console.WriteLine("Karakter jongkok dari berdiri");
            }
            else if (currentState == State.Jongkok)
            {
                currentState = State.Tengkurap;
                Console.WriteLine("Karakter tengkurap dari jongkok");
            }
            else if (currentState == State.Terbang)
            {
                currentState = State.Berdiri;
                Console.WriteLine("Karakter landing (Berdiri)");
            }
        }

        public void TombolX()
        {
            if (currentState == State.Terbang)
            {
                currentState = State.Jongkok;
                Console.WriteLine("Karakter landing langsung ke jongkok");
            }
        }
    }
}
