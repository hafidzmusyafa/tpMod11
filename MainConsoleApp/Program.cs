using System;
using AljabarLibraries;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Menggunakan Library Kalkulator Aljabar ---");
        Console.WriteLine();

        // Contoh 1: Mencari Akar Persamaan Kuadrat (x^2 - 3x - 10 = 0)
        // Koefisien: a=1, b=-3, c=-10
        double[] persamaanKuadrat = { 1, -3, -10 };
        Console.WriteLine($"Mencari akar dari: {persamaanKuadrat[0]}x^2 + ({persamaanKuadrat[1]})x + ({persamaanKuadrat[2]}) = 0");

        try
        {
            double[] akar = KalkulatorAljabar.AkarPersamaanKuadrat(persamaanKuadrat);
            // Cek jika hasilnya NaN (Not a Number), yang kita gunakan untuk akar imajiner
            if (double.IsNaN(akar[0]))
            {
                Console.WriteLine("Hasil: Persamaan memiliki akar imajiner.");
            }
            else
            {
                Console.WriteLine($"Hasil: Akar-akarnya adalah x1 = {akar[0]:F2} dan x2 = {akar[1]:F2}");
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan umum: {ex.Message}");
        }


        Console.WriteLine();

        // Contoh 2: Mendapatkan Hasil Kuadrat (2x - 3)
        // Koefisien: a=2, b=-3
        double[] persamaanLinear = { 2, -3 };
        Console.WriteLine($"Mencari hasil kuadrat dari: ({persamaanLinear[0]})x + ({persamaanLinear[1]})");

        try
        {
            double[] hasilKuadrat = KalkulatorAljabar.HasilKuadrat(persamaanLinear);
            // Hasilnya adalah koefisien [A, B, C] untuk Ax^2 + Bx + C
            Console.WriteLine($"Hasil Kuadrat: {hasilKuadrat[0]}x^2 + ({hasilKuadrat[1]})x + ({hasilKuadrat[2]})");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan umum: {ex.Message}");
        }

        Console.WriteLine("\nTekan Enter untuk keluar...");
        Console.ReadLine();
    }
}