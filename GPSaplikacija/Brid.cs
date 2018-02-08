﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    public class Brid : IComparable<Brid>
    {
        Čvor početniČvor;
        Čvor završniČvor;
        double vrijemeProlaska;

        public Brid(Čvor početni, Čvor završni, double vrijeme)
        {
            početniČvor = početni;
            završniČvor = završni;
            vrijemeProlaska = vrijeme;
            Console.WriteLine("Dodan brid s pocetnim čvorom na (" + početniČvor.X + "," + početniČvor.Y + ") i zavrsnim čvorom na (" + završniČvor.X + "," + završniČvor.Y + ") te vremenom " + vrijemeProlaska);
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
