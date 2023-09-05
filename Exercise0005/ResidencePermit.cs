using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise0005.Countries;

namespace Exercise0005
{
    public static class ResidencePermit
    {
        public static void Permit(AbsCountry country)
        {
            try
            {
                country = (EuZoneCountry)country;
                Console.WriteLine($"Applicazione per il permesso di soggiorno del paese {country.Name}");
            }
            catch
            {
                Console.WriteLine("no");
            }
        }
    }
}
