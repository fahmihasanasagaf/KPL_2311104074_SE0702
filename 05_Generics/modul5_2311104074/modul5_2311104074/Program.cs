class Program
{
    static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();

        // NIM: 231110474 (akhir = 4 → pakai double)
        double hasil = p.JumlahTigaAngka(23.0, 11.0, 10.0);
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}
