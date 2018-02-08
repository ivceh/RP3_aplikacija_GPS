using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    public class Brid : IComparable<Brid>
    {
        string naziv;
        Čvor početniČvor;
        Čvor završniČvor;
        double vrijemeProlaska;

        public Brid(string naziv, Čvor početni, Čvor završni, double vrijeme)
        {
            this.naziv = naziv;
            početniČvor = početni;
            završniČvor = završni;
            vrijemeProlaska = vrijeme;
            Console.WriteLine("Dodan brid od " + početniČvor.naziv + " do " + završniČvor.naziv + " s vremenom " + vrijemeProlaska);
        }

        public int CompareTo(Brid nekiBrid)
        {
            if (početniČvor.CompareTo(nekiBrid.početniČvor) != 0)
                return početniČvor.CompareTo(nekiBrid.početniČvor);
            else
                return završniČvor.CompareTo(nekiBrid.završniČvor);
        }

        public Čvor PočetniČvor
        {
            get { return početniČvor;  }
        }

        public Čvor ZavršniČvor
        {
            get { return završniČvor; }
        }

        public double VrijemeProlaska
        {
            get { return vrijemeProlaska; }
        }
    }
}
