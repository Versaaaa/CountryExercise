using System;

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
                return rng.Next();
            }
            catch
            {
                return 0;
            }
        }
    }
}
