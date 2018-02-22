using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSaplikacija
{
    public class Dijkstra
    {
        public SortedSet<Čvor> neprođeniČvorovi = new SortedSet<Čvor>();
        public Dictionary<Čvor, double> udaljenostiOdPocetka = new Dictionary<Čvor, double>();
        public Dictionary<Čvor, Čvor> prethodniČvorovi = new Dictionary<Čvor, Čvor>();

        public Dijkstra()
        {

        }

        public Dictionary<Čvor, Čvor> nadiPutIzmedu(Čvor c1, Čvor c2)
        {
            foreach (Čvor cv in Plan.skupČvorova.Values)
            {
                Console.WriteLine(cv);
                udaljenostiOdPocetka[cv] = Double.MaxValue;
                prethodniČvorovi[cv] = null;
                neprođeniČvorovi.Add(cv);
            }
            udaljenostiOdPocetka[c1] = 0;

            while(neprođeniČvorovi.Count != 0)
            {
                Čvor trenutni = neprođeniČvorovi.Last();
                Console.WriteLine("trenutni cvor: " + trenutni);

                if (trenutni.naziv == c2.naziv)
                {
                    Console.WriteLine("KRAJ");
                    break;
                }

                foreach (Brid susjedniBrid in trenutni.skupSusjednihBridova)
                {
                    Console.WriteLine("susjed od " + trenutni + " -> " + susjedniBrid);

                    double alt = udaljenostiOdPocetka[trenutni] + susjedniBrid.VrijemeProlaska;
                    Čvor susjedniČvor = susjedniBrid.PočetniČvor == trenutni ? susjedniBrid.ZavršniČvor : susjedniBrid.PočetniČvor;
                    if (alt < udaljenostiOdPocetka[susjedniČvor])
                    {
                        udaljenostiOdPocetka[susjedniČvor] = alt;
                        prethodniČvorovi[susjedniČvor] = trenutni;
                    }
                }

                neprođeniČvorovi.Remove(trenutni);
            }

            return prethodniČvorovi;
        }
    }
}
