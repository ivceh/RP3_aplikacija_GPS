﻿using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace GPSaplikacija
{
    public static class Plan
    {
        public static List<Čvor> skupČvorova = new List<Čvor>();
        public static List<Brid> skupBridova = new List<Brid>();

        public static void UcitajPlan(String confFile)
        {
            try
            {
                string planString = System.IO.File.ReadAllText(@"../../gradovi/" + confFile);
                JObject planObjekt = JObject.Parse(planString);

                JArray cvorovi = (JArray)planObjekt["cvorovi"];
                JArray bridovi = (JArray)planObjekt["bridovi"];

                for (int i = 0; i < cvorovi.Count; i++)
                    DodajČvor((string)cvorovi[i]["naziv"], (Double)cvorovi[i]["x"], (Double)cvorovi[i]["y"]);
                for (int i = 0; i < bridovi.Count; i++)
                    DodajBrid((string)bridovi[i]["naziv"], skupČvorova[(int)bridovi[i]["c1"]], skupČvorova[(int)bridovi[i]["c2"]], (double)bridovi[i]["vrijeme"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DodajČvor(string n, double x, double y)
        {
            skupČvorova.Add(new Čvor(n, x, y));
        }

        public static void DodajBrid(string n, Čvor p, Čvor z, double vrijeme)
        {
            skupBridova.Add(new Brid(n, p, z, vrijeme));
        }

        public static List<Čvor> SkupČvorova
        {
            get { return skupČvorova; }
        }

        public static List<Brid> SkupBridova
        {
            get { return skupBridova; }
        }
    }
}
