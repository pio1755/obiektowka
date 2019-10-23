using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            lucznik Legolas = new lucznik("Legolas", 100, 15, 8);
            wojownik Aragorn = new wojownik("Aragorn", 100, 20, 3);
            Aragorn.zamianaZycia(-120);
            Aragorn.zamianaZycia(+21);
            Aragorn.atak();


            Console.ReadKey();
        }
    }
}

public class bohater
{
    protected String imie;
    protected int HP;
    public bohater(String imie,int HP)
    {
        this.imie = imie;
        this.HP = HP;
    }
    public void atak(int mocno,int PT)
    {
        float mocAtk;
        mocAtk = mocno * PT * (this.HP*(1/100));
       Console.WriteLine("Moc ataku wynosi: " + mocAtk);
    }
    public void zamianaZycia(int ilePkt)
    {
        if(this.HP+ilePkt<0)
        {
            this.HP = 0;
            Console.WriteLine("Punkty HP rowne 0, bohater nie zyje");
        }
        else if(this.HP+ilePkt>100)
        {
            this.HP = 100;
            Console.WriteLine("HP wynosi 100HP, nie moza wyzej");
        }
        else
        {
            this.HP = this.HP + ilePkt;
            Console.WriteLine("HP zmieniono na"+ this.HP);
        }
    }

}

 class wojownik:bohater
{
    private int zrecznosc;
    private int PT;
    public wojownik(String imie,int HP,int zrecznosc,int PT):base(imie,HP)
    {
        this.zrecznosc = zrecznosc;
        this.PT = PT;

    }


    public void atak()
    {
        float mocAtk;
        float hape = (float)this.HP/100;
        if(this.HP>=20)
            mocAtk = this.zrecznosc * this.PT *hape;
        else
            mocAtk = this.zrecznosc * this.PT * (3/2);
        Console.WriteLine("Moc ataku wynosi: " + mocAtk);
    }


}
public class lucznik:bohater
{
    private int sila;
    private int PT;
    public lucznik(String imie, int HP, int sila, int PT) : base(imie, HP)
    {
        this.sila = sila;
        this.PT = PT;

    }


}
