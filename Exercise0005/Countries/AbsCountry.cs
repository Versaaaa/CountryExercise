using System;
using Exercise0005.Interfaces;

namespace Exercise0005.Countries
{
    public abstract class AbsCountry : PoliticalEntity,IONU 
    {
        protected int _population = 0;
        public virtual int Population 
        {
            get { return _population; }
            set { _population = value; }
        }
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
