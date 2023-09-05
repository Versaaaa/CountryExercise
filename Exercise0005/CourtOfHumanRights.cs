using System;
using Exercise0005.Countries;

namespace Exercise0005
{
    public static class CourtOfHumanRights
    {
        public static bool Judge(AbsCountry country)
        {
            try
            {
                country = (DeathPenaltyCountry)country;
                Console.WriteLine($"Il paese non rispetta i diritti umani");
                return true;
            }
            catch
            {
                Console.WriteLine($"Il paese rispetta i diritti umani");
                return false;
            }
        }
    }
}
