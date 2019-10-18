using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            Car pierwszy = new Car(1.9,"Focus");

            Car drugi = Car.Create(1.8,"cos");

            drugi.wypisz();
            Console.WriteLine(drugi.nr);


            Car[] samochody=new Car[100];
           for(int i=0;i<99; i++)
            {
                samochody[i] = new Car(1.5, "test");
                samochody[i].wypisz();
            }


            Console.ReadKey();
        }
    }

    public class Car
    {
        public  int nr=1;
        double pojemnoscSilnika;
        static int nastepny=0;
        String marka;
        static int iloscKol;


        public Car()
        {
            nr =nr+ nastepny;
            nastepny++;
            this.pojemnoscSilnika = 2.0;
            this.marka = "randomowa";
            nr = nastepny++;

        }
        public  Car(double poj,String marka)
        {
            nr = nr + nastepny;
            nastepny++;
            this.pojemnoscSilnika = poj;
            this.marka = marka;
        }
        static Car()
        {
            iloscKol = 4;
        }
         ~Car()
        {
            Console.WriteLine("Zwalniam pamięć");
            Console.ReadKey();
        }

        public static Car Create(double poj, String marka)
        {
            Car samochod = new Car(poj,marka);
            return samochod;
        }
        public void wypisz()
        {

            Console.WriteLine("pojemmnosc: " +this.pojemnoscSilnika+"nr: "+ this.nr+"marka: " +this.marka);

        }

    }
}
