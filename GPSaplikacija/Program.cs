﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSaplikacija
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DatabaseConnection.CheckSqlConnection();
                DatabaseUpiti.StvoriPlanIzBaze();
            }
            catch
            {
                Plan.UcitajPlan("zagreb-centar.txt");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //DatabaseConnection.CheckSqlConnection();

            Form1 forma = new Form1();
            forma.SkalirajMapuPoPlanu();
            Application.Run(forma);
        }
    }
}
