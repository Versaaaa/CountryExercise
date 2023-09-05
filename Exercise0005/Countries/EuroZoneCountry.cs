using System;
using System.Runtime.CompilerServices;
using Exercise0005.Interfaces;

namespace Exercise0005.Countries
{
    public class EuroZoneCountry : EuZoneCountry, IEuroZone
    {
        public static int euroZonePopulation = 0;

        public Action residencePermitAction;

        public override int Population
        {
            get { return _population; }
            set
            {
                int x = value - _population;
                _population = value;
                euroZonePopulation += x;
            }
        }
        public int Spread { get { return EuroCentralBank.Spread(this); } }
        public int Debt { get; set; }

        public override void Organization()
        {
            Console.WriteLine("Appartengo all'Eurozona");
        }

        public EuroZoneCountry(string name) : base(name)
        {
            ApplyEuro();
        }
        
        public void ApplyEuro()
        {
            Coin = "Euro";
        }
    }
}
