using System;

class Program
{
    static void Main()
    {
        // Sapa dengan String
        HaloGeneric<string> sapaString = new HaloGeneric<string>("Fahmi");
        sapaString.SapaUser();  // Output: Halo, Fahmi!

        HaloGeneric<string> sapaNIM = new HaloGeneric<string>("2311104074");
        sapaNIM.SapaUser();


        // Sapa dengan Tahun (jika memang ingin tahun)
        HaloGeneric<int> sapaTahun = new HaloGeneric<int>(2025);
        sapaTahun.SapaUser();  // Output: Halo, 2025!
    }
}
