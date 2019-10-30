using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Bicycle bicycle1 = new Bicycle();

            car1.Ride();
            bicycle1.Ride();

            Osoba osoba1 = new Osoba();
            osoba1.Graj();

            IGitarzysta gitarzysta1 = osoba1;
            gitarzysta1.Graj();
            

            Console.ReadKey();
        }
    }

    class Vehicle
    {


    }

    class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jade samochodem");

        }


    }
    class Bicycle : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jade rowerem");


        }


    }
    interface IRideable
    {
        void Ride();


    }
    class Osoba: IGitarzysta, ISkrzypek
    {

        public void Graj()
        {
            Console.WriteLine("Gram ale nie wiem na czym");
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram na gitarze");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }


    }
    
        interface IGitarzysta
    {
        void Graj();
    }
        interface ISkrzypek
    {
        void Graj();
    }

}
