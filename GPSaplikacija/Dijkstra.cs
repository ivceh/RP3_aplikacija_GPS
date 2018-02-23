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
            foreach (Brid br in Plan.skupBridova.Values)
            {
                br.isDioPuta = false;
            }

            neprođeniČvorovi.Clear();

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
                Console.WriteLine("NEPROĐENI ČVOROVI:");
                foreach (Čvor cv in neprođeniČvorovi)
                {
                    Console.WriteLine(cv);
                }

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
                    susjedniBrid.isDioPuta = false;

                    double alt = trenutni.udaljenostOdPocetka + susjedniBrid.VrijemeProlaska;
                    Čvor susjedniČvor = susjedniBrid.PočetniČvor == trenutni ? susjedniBrid.ZavršniČvor : susjedniBrid.PočetniČvor;
                    if (alt < susjedniČvor.udaljenostOdPocetka)
                    {
                        neprođeniČvorovi.Remove(susjedniČvor);
                        susjedniČvor.udaljenostOdPocetka = alt;
                        susjedniČvor.bridPrethodnik = susjedniBrid;
                        neprođeniČvorovi.Add(susjedniČvor);
                    }
                }

                neprođeniČvorovi.Remove(trenutni);
            }

            Console.WriteLine("skup neprođenih čvorova je PRAZAN");
        }
    }
}
