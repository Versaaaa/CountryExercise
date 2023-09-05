﻿using System;
using System.Runtime.CompilerServices;
using Exercise0005.Interfaces;

namespace Exercise0005.Countries
{
    public class EuroZoneCountry : EuZoneCountry, IEuroZone
    {
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