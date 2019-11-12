using System;
using System.Collections.Generic;

namespace Wejsciowka3
{
    public abstract class Osoba
    {
        public string imie;
        public string nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public void Pracuj()
        {

        }
        public void PrzygotujKawe()
        {
            Console.WriteLine(this.imie + " " + this.nazwisko + " parzy kawę.");
        }
    }
    public class Firma
    {
        public List<Osoba> pracownicy = new List<Osoba>();

    }
    public class Dyrektor : Osoba
    {
        public string sekretarka;

        public Dyrektor(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }
       
        public void PrzypiszSekretarke(Sekretarka xd)
        {
            this.sekretarka = xd.imie +" "+ xd.nazwisko;
        }
        public void PrzygotujKawe()
        {
            if(this.sekretarka == null)
            {
                Console.WriteLine("Dyrektor " + this.imie + " " + this.nazwisko + " parzy kawę.");
            }
            else
            {
                Console.WriteLine("Sekretarka " + this.sekretarka + " parzy kawę.");
            }
        }
    }
    public class Sekretarka : Osoba
    {
        //   public string stanowisko = "Sekretarka";
        public void PrzygotujKawe()
        {
            Console.WriteLine("Sekretarka " + this.imie + " " + this.nazwisko + " parzy kawę.");
        }
        public Sekretarka(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }
    }
    public class Mechanik : Osoba
    {
        public void PrzygotujKawe()
        {
            Console.WriteLine("Mechanik " + this.imie + " " + this.nazwisko + " parzy kawę.");
        }
        public Mechanik(string imie, string nazwisko) : base(imie, nazwisko)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma listapracownikow = new Firma();
            Sekretarka Ola = new Sekretarka("Ola", "Skorupska");
            Dyrektor Bartosz = new Dyrektor("Bartosz", "Kwasiborski");
            Mechanik Kisiel = new Mechanik("Michał", "Kisiel");
            //Bartosz.PrzypiszSekretarke(Ola);
            Bartosz.PrzygotujKawe();
            Kisiel.PrzygotujKawe();
        }
    }
}
