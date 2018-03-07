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
            Konijn knabbel = new Konijn();
            Konijn flappie = new Konijn();
            Rabbit rabbit = new Rabbit();

            rabbit.huppelen($"Het konijn {name} doet huppel huppel.");
            knabbel.huppelen();
            flappie.huppelen();
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
        public string age, name;

        public Rabbit()
        {

        }

        public void huppelen()
        {
            string name = "knabbel";
        }
    }

}


