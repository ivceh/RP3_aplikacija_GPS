using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace GPSaplikacija
{
    public static class Plan
    {
        public static Dictionary<string, Čvor> skupČvorova = new Dictionary<string, Čvor>();
        public static Dictionary<string, Brid> skupBridova = new Dictionary<string, Brid>();

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

                    skupBridova[naz] = new Brid(naz, skupČvorova[poc], skupČvorova[zav], (double)bridovi[i]["vrijeme"]);

                    skupČvorova[poc].DodajSusjedniBrid(skupBridova[naz]);
                    skupČvorova[zav].DodajSusjedniBrid(skupBridova[naz]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
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
