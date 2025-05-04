using System;

namespace AljabarLibraries 
{
    public static class KalkulatorAljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            if (persamaan == null || persamaan.Length != 3)
            {
                throw new ArgumentException("Input array harus berisi 3 elemen [a, b, c].");
            }

            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            if (a == 0)
            {
                throw new ArgumentException("Koefisien 'a' tidak boleh nol untuk persamaan kuadrat.");
            }

            // Hitung diskriminan
            double diskriminan = (b * b) - (4 * a * c);

            double[] akar = new double[2];

            if (diskriminan < 0)
            {
                // Akar imajiner
                akar[0] = double.NaN; 
                akar[1] = double.NaN; 
            }
            else if (diskriminan == 0)
            {
                // Satu akar real (kembar)
                akar[0] = -b / (2 * a);
                akar[1] = akar[0]; // Akar kembar
            }
            else // diskriminan > 0
            {
                // Dua akar real berbeda
                akar[0] = (-b + Math.Sqrt(diskriminan)) / (2 * a);
                akar[1] = (-b - Math.Sqrt(diskriminan)) / (2 * a);
            }

            return akar;
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            if (persamaan == null || persamaan.Length != 2)
            {
                throw new ArgumentException("Input array harus berisi 2 elemen [a, b].");
            }

            double a = persamaan[0];
            double b = persamaan[1];

            // (ax + b)^2 = (a^2)x^2 + (2ab)x + (b^2)
            double A = a * a;
            double B = 2 * a * b;
            double C = b * b;

            return new double[] { A, B, C };
        }
    }
}