using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    class Brid : IComparable<Brid>
    {
        Čvor početniČvor;
        Čvor završniČvor;
        double vrijemeProlaska;

        public Brid(Čvor početni, Čvor završni, double vrijeme)
        {
            početniČvor = početni;
            završniČvor = završni;
            vrijemeProlaska = vrijeme;
        }

        public int CompareTo(Brid nekiBrid)
        {
            if (početniČvor.CompareTo(nekiBrid.početniČvor) != 0)
                return početniČvor.CompareTo(nekiBrid.početniČvor);
            else
                return završniČvor.CompareTo(nekiBrid.završniČvor);
        }
    }
}
