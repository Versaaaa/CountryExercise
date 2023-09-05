using System;
using System.Collections.Generic;

namespace Exercise0005
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<AbsCountry> list = new List<AbsCountry>{ new DeathPenaltyCountry("Nord Korea"), new EuZoneCountry("Hungary"), new EuroZoneCountry("Italy") };

            foreach (var i in list)
            {
                Console.WriteLine($"{CourtOfHumanRights.Judge(i)}");   
            }

            Console.WriteLine();

            foreach (var i in list)
            {
                Console.WriteLine($"{EuroCentralBank.Spread(i)}");   
            }

            Console.WriteLine();

            foreach (var i in list)
            {
                i.Organization();
            }
        }
    }

    //public class EuropeanCourtOfRights
    //{
    //    public static void Judge(StatoPenaDiMorte state)
    //    {
    //        Console.WriteLine($"Lo stato {state.Name} non rispetta i diritti umani.");
    //    }
    //    public static void Judge(StatoSenzaPenaDiMorte state)
    //    {
    //        Console.WriteLine($"Lo stato {state.Name} rispetta i diritti umani.");
    //    }
    //}

    //public class EuroCentralBank
    //{
    //    public int Spread() 
    //    { 
    //        Random rng = new Random();
    //        return rng.Next();
    //    }
    //}

    //public interface IState
    //{
    //    List<IStateOf> StateOfs {get;set;}
    //    String Name { get; set; }
    //    bool Judge();
    //}

    //public class StatoPenaDiMorte : IState
    //{
    //    public List<IStateOf> StateOfs { get; set; }

    //    public string Name { get; set; }

    //    public bool Judge()
    //    {
    //        EuropeanCourtOfRights.Judge(this);
    //        return false;
    //    }
    //}

    //public class StatoSenzaPenaDiMorte : IState
    //{
    //    public List<IStateOf> StateOfs { get; set; }

    //    public string Name { get; set; }

    //    public bool Judge()
    //    {
    //        EuropeanCourtOfRights.Judge(this);
    //        return true;
    //    }
    //}

    //public interface IStateOf
    //{
    //    string Name { get; }
    //    int Spread();
    //}

    //public class StateOfEurozone : IStateOf 
    //{ 
    //    EuroCentralBank bank;

    //    public string Name { get { return "Eurozone"; } }

    //    public int Spread() 
    //    {
    //        return bank.Spread();
    //    }

    //    public StateOfEurozone(EuroCentralBank bank)
    //    {
    //        this.bank = bank;
    //    }
    //}

    //public class StateOfONU : IStateOf
    //{
    //    public string Name { get { return "ONU"; } }

    //    public int Spread()
    //    {
    //        return 0;
    //    }
    //}

    //public class StateOfEU : IStateOf
    //{
    //    public string Name { get { return "EU"; } }

    //    public int Spread()
    //    {
    //        return 0;
    //    }
    //}
}
