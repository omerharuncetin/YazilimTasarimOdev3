using System;

namespace CodeAdaptationProblem
{
    class Program
    {
        static void Main(string[] args)
        {
           Savastir savastir = new Savastir();
           savastir.SilahKullan("Tank");
           savastir.SilahKullan("DusmanRobotu");
           
           savastir.Hizlan("Tank");
           savastir.Hizlan("DusmanRobotu");

           Console.WriteLine(savastir.DusmanAdi("Tank"));
           Console.WriteLine(savastir.DusmanAdi("DusmanRobotu"));
        }
    }
}