﻿using System;
using System.Buffers.Text;

namespace Exercise0005
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
