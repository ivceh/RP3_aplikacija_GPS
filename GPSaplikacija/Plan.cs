using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace GPSaplikacija
{
    public static class Plan
    {
        public static Dictionary<string, Čvor> skupČvorova = new Dictionary<string, Čvor>();
        public static Dictionary<string, Brid> skupBridova = new Dictionary<string, Brid>();

        public static Dijkstra dijkstrinAlgoritam = new Dijkstra();

        public static int DodajČvor(double koordinataX, double koordinataY, string naziv)
        {
            foreach (var p in SkupČvorova)
            {
                if (p.Value.X == koordinataX && p.Value.Y == koordinataY)
                {
                    Console.WriteLine("ERROR: DodajČvor(" + koordinataX + "," + koordinataY + "," + naziv + ") - čvor na tim koordinatama već postoji!");
                    return -2;
                }
            }

            try
            {
                skupČvorova.Add(naziv, new Čvor(naziv, koordinataX, koordinataY));
                return 1;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ERROR: DodajČvor("+koordinataX+","+koordinataY+","+naziv+") - čvor s tim nazivom već postoji!");
                return -1;
            }
        }


        public static string DodajBrid(string naziv, string početni, string završni, double vrijeme)
        {
            string poruka = ""; 
            if(početni == završni)
            {
                poruka = "Za brid mi trebaju dva različita čvora!";
                return poruka;
            }

            Čvor početniČvor = new Čvor("", 0, 0);
            Čvor završniČvor = new Čvor("", 0, 0);

            //nađi početni i završni čvor
            bool našaoPrvi = false, našaoDrugi = false;
            foreach(var p in skupČvorova)
            {
                if(p.Key == početni)
                {
                    našaoPrvi = true;
                    početniČvor = p.Value;
                }
                else if(p.Key == završni)
                {
                    našaoDrugi = true;
                    završniČvor = p.Value;
                }
            }

            if(našaoPrvi == false)
            {
                poruka = "Prvi čvor ne postoji (krivi unos)!";
            }
            else if(našaoDrugi == false)
            {
                poruka = "Drugi čvor ne postoji (krivi unos)!";
            }
            else
            {
                foreach(var p in skupBridova)
                {
                    //p.Value je tipa Brid
                    if (p.Value.PočetniČvor.naziv == početni && p.Value.ZavršniČvor.naziv == završni)
                    {
                        poruka = "Brid već postoji! Molimo dodajte neki drugi.";
                        return poruka;
                    } 
                }

                try
                {
                    Brid noviBrid;
                    skupBridova.Add(naziv, noviBrid = new Brid(naziv, početniČvor, završniČvor, vrijeme));
                    početniČvor.DodajSusjedniBrid(noviBrid);
                    završniČvor.DodajSusjedniBrid(noviBrid);
                    poruka = "Uspješno dodan brid od " + početni + " do " + završni + ".";
                }
                catch (ArgumentException)
                {
                    poruka = "Već postoji brid s tim nazivom! Molimo odaberite drugi naziv.";
                }

            }

            return poruka;
        }


        public static void UcitajPlan(String confFile)
        {
            try
            {
                string planString = System.IO.File.ReadAllText(@"../../gradovi/" + confFile);
                JObject planObjekt = JObject.Parse(planString);

                JArray cvorovi = (JArray)planObjekt["cvorovi"];
                JArray bridovi = (JArray)planObjekt["bridovi"];

                for (int i = 0; i < cvorovi.Count; i++)
                {
                    skupČvorova[(string)cvorovi[i]["naziv"]] = new Čvor((string)cvorovi[i]["naziv"], (Double)cvorovi[i]["x"], (Double)cvorovi[i]["y"]);
                }

                for (int i = 0; i < bridovi.Count; i++)
                {
                    string naz = (string)bridovi[i]["naziv"];
                    string poc = (string)bridovi[i]["pocetni"];
                    string zav = (string)bridovi[i]["zavrsni"];
                    double vrijeme = (double)bridovi[i]["vrijeme"];

                    DodajBrid(naz, poc, zav, vrijeme); // možda provjeriti rezultat izvršavanja
                    //skupBridova[naz] = new Brid(naz, skupČvorova[poc], skupČvorova[zav], (double)bridovi[i]["vrijeme"]);

                    //skupČvorova[poc].DodajSusjedniBrid(skupBridova[naz]);
                    //skupČvorova[zav].DodajSusjedniBrid(skupBridova[naz]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //nadiNajkraciPut(skupČvorova["PMF"], skupČvorova["Crnomerec"]);
        }

        public static void nadiNajkraciPut(String s1, String s2)
        {
            Čvor c1 = skupČvorova[s1];
            Čvor c2 = skupČvorova[s2];

            foreach (Brid br in skupBridova.Values)
            {
                br.isDioPuta = false;
            }

            dijkstrinAlgoritam.nadiPutIzmedu(c1, c2);

            //String messageText = "RJEŠENJE;\n";

            int putID = 0;
            Čvor cc = c2;
            while (cc.bridPrethodnik != null)
            {
                putID++;
                cc.bridPrethodnik.isDioPuta = true;
                //messageText += (putID + ".: " + cc.bridPrethodnik + "\n");
                cc = cc.bridPrethodnik.PočetniČvor == cc ? cc.bridPrethodnik.ZavršniČvor : cc.bridPrethodnik.PočetniČvor;
            }

            //MessageBox.Show(messageText,"NAJKRAĆI PUT",MessageBoxButtons.OK);
		}

        public static void nadiNajkraciPutUzPosao(String s1, String posao, String s2)
        {
            Čvor c1 = skupČvorova[s1];
            Čvor p;
            try
            {
                p = skupČvorova[posao];
            }
            catch
            {
                MessageBox.Show("Upišite postojeći čvor pa tražite ponovno", "Nepostojeći čvor!",MessageBoxButtons.OK);
                return;
            }
            Čvor c2 = skupČvorova[s2];

            foreach (Brid br in skupBridova.Values)
            {
                br.isDioPuta = false;
            }
           
            dijkstrinAlgoritam.nadiPutIzmedu(c1, p);

            //String messageText = "RJEŠENJE;\n";

            int putID = 0;
            Čvor cc = p;
            while (cc.bridPrethodnik != null)
            {
                putID++;
                cc.bridPrethodnik.isDioPuta = true;
                //messageText += (putID + ".: " + cc.bridPrethodnik + "\n");
                cc = cc.bridPrethodnik.PočetniČvor == cc ? cc.bridPrethodnik.ZavršniČvor : cc.bridPrethodnik.PočetniČvor;
            }

            dijkstrinAlgoritam.nadiPutIzmedu(p, c2);

            cc = c2;
            while (cc.bridPrethodnik != null)
            {
                putID++;
                cc.bridPrethodnik.isDioPuta = true;
                //messageText += (putID + ".: " + cc.bridPrethodnik + "\n");
                cc = cc.bridPrethodnik.PočetniČvor == cc ? cc.bridPrethodnik.ZavršniČvor : cc.bridPrethodnik.PočetniČvor;
            }

            //MessageBox.Show(messageText,"NAJKRAĆI PUT",MessageBoxButtons.OK);
        }

        public static Dictionary<string, Čvor> SkupČvorova
        {
            get { return skupČvorova; }
        }

        public static Dictionary<string, Brid> SkupBridova
        {
            get { return skupBridova; }
        }
    }
}
