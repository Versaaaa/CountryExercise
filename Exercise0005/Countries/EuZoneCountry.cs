using System;
using System.Buffers.Text;
using Exercise0005.Interfaces;

namespace Exercise0005.Countries
{
    public class EuZoneCountry : AbsCountry, IEU
    {

        public EuZoneCountry(string name) : base(name) { }

        public override void Organization()
        {
            Console.WriteLine("Appartengo all'Unione Europea");
        }

        public void ApplyHumanRights()
        {
            //throw new NotImplementedException();
        }

        public void ConstitutionIntegration()
        {
            //throw new NotImplementedException();
        }
    }
}
