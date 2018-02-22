using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    public class Čvor : IComparable<Čvor>
    {
        public string naziv;
        double x;
        double y;
        public SortedSet<Brid> skupSusjednihBridova = new SortedSet<Brid>();

        // podatci vezani uz Dijkstrino traženje
        public double udaljenostOdPocetka;
        public Brid bridPrethodnik;

        public Čvor(string naziv, double x, double y)
        {
            this.naziv = naziv;
            this.x = x;
            this.y = y;
            Console.WriteLine("Dodan čvor " + this.naziv + " s kordinatama (" + this.x + "," + this.y + ")");
        }

        public void DodajSusjedniBrid(Brid susjed)
        {
            skupSusjednihBridova.Add(susjed);
        }

        public int CompareTo(Čvor nekiČvor)
        {
            return udaljenostOdPocetka.CompareTo(nekiČvor.udaljenostOdPocetka);
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public override string ToString()
        {
            return naziv + " (" + x.ToString() + "," + y.ToString() + ")";
        }
    }
}
