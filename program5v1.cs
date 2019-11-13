using System;

namespace lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p = new Programista();
            p.Pracuj();
            Console.ReadKey();

        }
    }
    public class Pracownik
    {

        public virtual void Pracuj()
        {
           Console.WriteLine("logowanie");
        }
    }
    public class Programista : Pracownik
    {
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Obowiazki programisty");

        }

    } 
}
