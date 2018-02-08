using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    class Plan
    {
        SortedSet<Čvor> skupČvorova = new SortedSet<Čvor>();
        SortedSet<Brid> skupBridova = new SortedSet<Brid>();

        public void DodajČvor(double x, double y)
        {
            skupČvorova.Add(new Čvor(x, y));
        }

        public void DodajBrid(Čvor p, Čvor z, double vrijeme)
        {
            skupBridova.Add(new Brid(p, z, vrijeme));
        }

        public SortedSet<Čvor> SkupČvorova
        {
            get { return skupČvorova; }
        }

        public SortedSet<Brid> SkupBridova
        {
            get { return SkupBridova; }
        }
    }
}
