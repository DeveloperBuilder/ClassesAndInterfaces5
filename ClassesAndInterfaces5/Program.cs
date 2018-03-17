using KinderBoerderij;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces5
{
    class Program
    {
        /* Maak een voorbeeld console-applicatie KinderBoerderij, met daarin twee konijnen (knabbel en flappie). 
           Een konijn heeft een leeftijd (int) en kan huppelen. Wanneer het konijn huppelt, wordt er tekst op het scherm geprint. 
           Laat in de applicatie beide konijnen huppelen. */

        static void Main(string[] args)
        {
            Rabbit rabbit = new Rabbit();
            rabbit.DoRabbit();
            Console.ReadLine();
        }

    }

}

namespace KinderBoerderij
{
    class Konijn
    {
        private string leeftijd;

        public void huppelen()
        {
            Console.WriteLine("Huppel Huppel");
        }
    }

    class Rabbit
    {
        private string age;
        private string _naam = "knabbel";
        private string _naam2 = "flappie";

        public void DoRabbit()
        {
            Console.WriteLine($"{_naam} doet huppel huppel");
            Console.WriteLine($"{_naam2} doet huppel huppel");
        }
    }
}


