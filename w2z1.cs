namespace Wejsciowka2
{
    public abstract class Napoj
    {
        private string nazwa;
        private int cena;
        public int _cena
        {
            get
            {
                return cena;
            }
            set
            {
                _cena = value;
            }
        }
        public Napoj(string nazwa, int cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }
        public void Przygotuj()
        {
            Console.WriteLine("Przygotowuję napój " + this.nazwa + ". Cena: " + this.cena);

        }
    }
    public class Automat
    {
        public string nazwa;
        public string model;
        public int stanKasy;
        public void PrzygotujNapoj(Napoj xd)
        {
            this.stanKasy += xd._cena;
            Console.WriteLine("Stan kasy wynosi: " + this.stanKasy);
            xd.Przygotuj();
        }
    }

    public class napoj_gazowany : Napoj
    {
       public napoj_gazowany(string nazwa, int cena) : base(nazwa, cena)
        {
        }
    }
    public class napoj_niegazowany : Napoj
    {
        public napoj_niegazowany(string nazwa, int cena) : base(nazwa, cena)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            napoj_gazowany Cola = new napoj_gazowany("Coca cola", 23);
            napoj_niegazowany Tymbark = new napoj_niegazowany("Tymbark", 24);
            Automat Automacik = new Automat();
            Automacik.PrzygotujNapoj(Cola);
            Automacik.PrzygotujNapoj(Tymbark);

        }
    }
}
