using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    public class Brid : IComparable<Brid>, IEquatable<Brid>
    {
        string naziv;
        Čvor početniČvor;
        Čvor završniČvor;
        double vrijemeProlaska; //u sekundama

        // podaci vezani uz Dijkstrino traženje
        public bool isDioPutaIliImaKarakteristiku = false;

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
            return vrijemeProlaska.CompareTo(nekiBrid.vrijemeProlaska);
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

        public string Naziv
        {
            get { return naziv; }
        }

        public override string ToString()
        {
            return naziv + " (" + početniČvor.ToString() + "," + završniČvor.ToString() + ")";
        }

        public bool Equals(Brid other)
        {
            return početniČvor.Equals(other.početniČvor) && završniČvor.Equals(other.završniČvor);
        }

        public override int GetHashCode()
        {
            return unchecked(početniČvor.GetHashCode() + završniČvor.GetHashCode());
        }
    }
}
