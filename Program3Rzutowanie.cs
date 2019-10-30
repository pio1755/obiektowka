using System;

namespace rzutowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass myObj = new BaseClass();
            //   DerrivedClass derObj1 = (DerrivedClass)myObj;
            //    NextDerrivedClass NxtObj1 = (NextDerrivedClass)myObj;
            DerrivedClass derObj1 = new DerrivedClass();

            //Z podklasy do nadklasy mozna. z nadklasy do podklasy juz nie.


                Console.ReadKey();


        }
    }
}


class BaseClass
{


}

class DerrivedClass : BaseClass
{



}

class NextDerrivedClass : DerrivedClass
{



}
