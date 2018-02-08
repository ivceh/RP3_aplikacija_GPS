using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    public class Čvor : IComparable<Čvor>
    {
        double x;
        double y;
        SortedSet<Brid> skupSusjednihBridova = new SortedSet<Brid>();

        public Čvor(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public void DodajSusjedniBrid(Brid susjed)
        {
            skupSusjednihBridova.Add(susjed);
        }

        public int CompareTo(Čvor nekiČvor)
        {
            if (x.CompareTo(nekiČvor.x) != 0)
                return x.CompareTo(nekiČvor.x);
            else
                return y.CompareTo(nekiČvor.y);
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }
    }
}
