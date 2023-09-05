using System;
using Exercise0005.Countries;

namespace Exercise0005
{
    public static class EuroCentralBank
    {
        public static int Spread(AbsCountry country)
        {
            try
            {
                country = (EuroZoneCountry)country;
                Random rng = new Random();
                int spread = rng.Next();

                Console.WriteLine($"Lo spread del paese equivale a {spread}");

                return spread;
            }
            catch
            {
                Console.WriteLine("La Banca Centrale Europea non può calcolare lo spread del paese");
                return 0;
            }
        }
    }
}
