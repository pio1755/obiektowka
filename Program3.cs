using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student pierwszy = new Student("Arek","Nazwiskowy",1999,1,1,132456);

            Console.WriteLine(pierwszy.ObliczWiek());
            Student drugi = new Student("Mirek", "Nazwiskowykdedk", 2001, 1, 1, 132416);
            Osoba pierwsz = new Osoba("Jarek", "Nazwiskowydedkk", 2001);
            Osoba drug = new Osoba("Zbuchu", "Nazwiskowykdwk", 2001);
            Console.ReadKey();
         //   pierwszy = pierwsz; nie dziala!!
         //   drug = drugi; dziala!!

        }
    }
}

class Osoba
{
    protected String imie;
    protected String Nazwisko;
    protected int rok_ur;
    public Osoba(String imie, String nazwisko, int rok_ur)
    {
        this.imie = imie;
        this.Nazwisko = nazwisko;
        this.rok_ur = rok_ur;

    }
    public int ObliczWiek()
    {
        int aktWiek;
        aktWiek = 2019 - rok_ur;
        return aktWiek;
    }


}
class Student:Osoba
{
    int rok;
    int numerGrupy;
    int numerAlbumu;
    public Student(String imie,String nazwisko,int rok_ur, int rok, int numerGrupy,int numerAlbumu): base(imie, nazwisko, rok_ur)
    {
        this.rok = rok;
        this.numerGrupy = numerGrupy;
        this.numerAlbumu = numerAlbumu;
    }

    void WypiszInfo()
    Console.WriteLine("Imie "+this.imie+" Nazwisko: "+this.Nazwisko+" Aktualny wiek: "+ObliczWiek()+"Numer Grupy: "+this.numerGrupy+" numer Albumu: "+this.numerAlbumu);
}
