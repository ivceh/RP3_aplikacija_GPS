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

        public Dijkstra()
        {

        }

        public void nadiPutIzmedu(Čvor c1, Čvor c2)
        {
            foreach (Čvor cv in Plan.skupČvorova.Values)
            {
                cv.udaljenostOdPocetka = Double.MaxValue;
                cv.bridPrethodnik = null;
                if (cv.naziv == c1.naziv)
                {
                    cv.udaljenostOdPocetka = 0;
                }

                neprođeniČvorovi.Add(cv);
            }

            while(neprođeniČvorovi.Count != 0)
            {
                Čvor trenutni = neprođeniČvorovi.First();
                Console.WriteLine("trenutni cvor: " + trenutni);

                if (trenutni.naziv == c2.naziv)
                {
                    Console.WriteLine("KRAJ");
                    break;
                }

                foreach (Brid susjedniBrid in trenutni.skupSusjednihBridova)
                {
                    Console.WriteLine("susjed od " + trenutni + " -> " + susjedniBrid);

                    double alt = trenutni.udaljenostOdPocetka + susjedniBrid.VrijemeProlaska;
                    Čvor susjedniČvor = susjedniBrid.PočetniČvor == trenutni ? susjedniBrid.ZavršniČvor : susjedniBrid.PočetniČvor;
                    if (alt < susjedniČvor.udaljenostOdPocetka)
                    {
                        susjedniČvor.udaljenostOdPocetka = alt;
                        susjedniČvor.bridPrethodnik = susjedniBrid;
                    }
                }

                neprođeniČvorovi.Remove(trenutni);
            }
        }
    }
}
