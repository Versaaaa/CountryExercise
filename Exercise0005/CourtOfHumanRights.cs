using System;

namespace Exercise0005
{
    public static class CourtOfHumanRights
    {
        public static bool Judge(AbsCountry country)
        {
            try
            {
                country = (DeathPenaltyCountry)country;
                Console.WriteLine($"Il paese {country.Name} non rispetta i diritti umani");
                return true;
            }
            catch
            {
                Console.WriteLine($"Il paese {country.Name} rispetta i diritti umani");
                return false;
            }
        }
    }
}
