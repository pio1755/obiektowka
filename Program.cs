using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 

    public class Car
    {
        private String marka = "";
        private int rok;
        private String model = "";
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public int srednieSpalanie;
        public Car(string marka, int rok)
        {
            this.marka = marka;
            this.rok = rok;
        }
        public String getCarMarka()
        {
            String markap = this.marka;
            return markap;
        }
        public int getCarRok()
        {
            int rokp = this.rok;
            return rokp;
        }
        public void wypisz()
        {
            Console.WriteLine("Marka samochodu: "+getCarMarka()+", "+"Rok produkcji: "+getCarRok());

        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            double spalanie = dlugoscTrasy * this.srednieSpalanie;

            return spalanie;
        }
        public double KosztPrzejazdu(double dlugoscTrasy,double CenaPaliwa)
        {
            double KosztPrzejazdu = OblczSpalanie(dlugoscTrasy) * CenaPaliwa;

            return KosztPrzejazdu;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            string carName = "Mój samochód";
            Console.WriteLine(carName);
            

            Car car1 = new Car("Ford", 2015);

            car1.wypisz();


            Car car2 = new Car("Mustang", 2019);

            car2.wypisz();

           // car1 = car2;
            //przy wypisywaniu zarowno car1 jak i car2 wypisuje się car2.
            //Jest to spowodowane tym, że do car1 został przypisany adres obiektu car2 (takzwane przypisywanie zmiennych referencyjnych)



            Console.ReadKey();


        }

    

    }

}
