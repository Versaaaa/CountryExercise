using System;

namespace Exercise0005
{
    public abstract class AbsCountry : IONU
    {
        public int Population { get; set; }
        public string Coin { get; set; }
        public string Government { get; set; }

        public string Name { get; set; }

        public AbsCountry(string name)
        {
            Name = name;
        }

        public virtual void Organization()
        {
            Console.WriteLine("Appartengo all'Onu");
        }

        public void PopulationControl()
        {
            //throw new NotImplementedException();
        }

        public void TerritorialControl()
        {
            //throw new NotImplementedException();
        }
    }
}
