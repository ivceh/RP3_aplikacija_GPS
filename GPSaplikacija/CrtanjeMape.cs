using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GPSaplikacija
{
    partial class Form1
    {
        double budućiČvorX;
        double budućiČvorY;
        bool budućiČvorPostoji = false;
        bool uPostupkuDodavanjaČvora = false;
        bool uPostupkuOznačavanjaČvorova = false;

        // koordinate dijela koji mapa prikazuje
        double xlijevi = 0, xdesni = 1000, ygornji = 0, ydonji = 1000;

        // skalira x iz intervala [minx, maxx] na interval [miny, maxy]
        static double Skaliraj (double x, double minx, double maxx, double miny, double maxy)
        {
            return (x - minx) / (maxx - minx) * (maxy - miny) + miny;
        }

        public void SkalirajMapuPoPlanu()
        {
            double visina = pictureBox1.Height - 40;
            double širina = pictureBox1.Width - 40;

            if(Plan.SkupČvorova.Any() && Plan.SkupČvorova.Count > 1)
            {
                double minx, maxx, miny, maxy;

                var čvorovi = Plan.skupČvorova.Values;

                minx = čvorovi.Min(a => a.X);
                miny = čvorovi.Min(a => a.Y);
                maxx = čvorovi.Max(a => a.X);
                maxy = čvorovi.Max(a => a.Y);

                if ((maxx-minx)/pictureBox1.Width > (maxy - miny) / visina)
                {
                    xlijevi = minx - 20;
                    xdesni = maxx + 20;
                    double ysrednji = (miny + maxy) / 2;
                    double novaVisina = (maxx - minx) * visina / širina;
                    ygornji = ysrednji - novaVisina / 2 - 20;
                    ydonji = ysrednji + novaVisina / 2 + 20;
                }
                else
                {
                    ygornji = miny - 20;
                    ydonji = maxy + 20;
                    double xsrednji = (minx + maxx) / 2;
                    double novaSirina = (maxy - miny) * širina / visina;
                    xlijevi = xsrednji - novaSirina / 2 - 20;
                    xdesni = xsrednji + novaSirina / 2 + 20;
                }
            }
        }

        // obrubi i sjenčanja
        static Pen pBridVanjska = new Pen(Color.Black, 7),
            pBridUnutarnja = new Pen(Color.Yellow, 5),
            pČvor = new Pen(Color.Black);
        Brush b = new SolidBrush(Color.Orange),
              textBrushDark = new SolidBrush(Color.Black),
              textBrushLight  =new SolidBrush(Color.White);

        // boje za Dijkstrin put
        Pen dijBridVanjska = new Pen(Color.Black, 7),
            dijBridUnutarnja = pBridUnutarnja.Color == Color.Green ? new Pen(Color.Red, 5) : new Pen(Color.Green, 5);

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Pen p in new Pen[]{pBridVanjska, pBridUnutarnja})
            {
                foreach (Brid b in Plan.SkupBridova.Values)
                {
                    Čvor cp = b.PočetniČvor, cz = b.ZavršniČvor;

                    float xpNaMapi, ypNaMapi, xzNaMapi, yzNaMapi;
                    xpNaMapi = (float)Skaliraj(cp.X, xlijevi, xdesni, 0, pictureBox1.Width);
                    ypNaMapi = (float)Skaliraj(cp.Y, ygornji, ydonji, 0, pictureBox1.Height);
                    xzNaMapi = (float)Skaliraj(cz.X, xlijevi, xdesni, 0, pictureBox1.Width);
                    yzNaMapi = (float)Skaliraj(cz.Y, ygornji, ydonji, 0, pictureBox1.Height);

                    if (b.isDioPuta)
                    {
                        g.DrawLine(dijBridVanjska, xpNaMapi, ypNaMapi, xzNaMapi, yzNaMapi);
                        g.DrawLine(dijBridUnutarnja, xpNaMapi, ypNaMapi, xzNaMapi, yzNaMapi);
                    }
                    else
                    {
                        g.DrawLine(p, xpNaMapi, ypNaMapi, xzNaMapi, yzNaMapi);
                    }

                    if (p == pBridUnutarnja)
                    {
                        bool tamniBrush = pictureBox1.BackColor.R > 100 && pictureBox1.BackColor.R > 100 && pictureBox1.BackColor.R > 100;
                        g.DrawString(b.Naziv, fontKojiKoristim, tamniBrush ? textBrushDark : textBrushLight, (xpNaMapi + xzNaMapi) / 2 - 20, (ypNaMapi + yzNaMapi) / 2 - 10);
                    }
                }
            }

            foreach (Čvor č in Plan.skupČvorova.Values)
            {
                float xNaMapi, yNaMapi;
                xNaMapi = (float)Skaliraj(č.X, xlijevi, xdesni, 0, pictureBox1.Width);
                yNaMapi = (float)Skaliraj(č.Y, ygornji, ydonji, 0, pictureBox1.Height);



                string defaultni = "- odabrani čvor: ";
                if (č.naziv == odabraniPočetniObavijest.Text.Substring(defaultni.Length) && uPostupkuOznačavanjaČvorova == true)
                {
                    Brush početni = new SolidBrush(Color.Blue);
                    g.FillEllipse(početni, xNaMapi - 5, yNaMapi - 5, 10, 10);
                }
                else if (č.naziv == odabraniZavršniObavijest.Text.Substring(defaultni.Length) && uPostupkuOznačavanjaČvorova == true)
                {
                    Brush završni = new SolidBrush(Color.Red);
                    g.FillEllipse(završni, xNaMapi - 5, yNaMapi - 5, 10, 10);
                }
                else
                {
                    g.FillEllipse(b, xNaMapi - 5, yNaMapi - 5, 10, 10);
                }
                g.DrawEllipse(pČvor, xNaMapi - 5, yNaMapi - 5, 10, 10);

                if (pictureBox1.BackColor.R > 100 && pictureBox1.BackColor.R > 100 && pictureBox1.BackColor.R > 100)
                {
                    g.DrawString(č.naziv, fontKojiKoristim, textBrushDark, xNaMapi, yNaMapi + 5);
                }
                else
                {  
                    g.DrawString(č.naziv, fontKojiKoristim, textBrushLight, xNaMapi, yNaMapi + 5);
                }
            }

            if(budućiČvorPostoji == true)
            {
                float xNaMapi, yNaMapi;
                xNaMapi = (float)Skaliraj(budućiČvorX, xlijevi, xdesni, 0, pictureBox1.Width);
                yNaMapi = (float)Skaliraj(budućiČvorY, ygornji, ydonji, 0, pictureBox1.Height);


                Brush ispunaNovogČvora = new SolidBrush(Color.Red);
                g.FillEllipse(ispunaNovogČvora, xNaMapi - 5, yNaMapi - 5, 10, 10);
                g.DrawEllipse(pČvor, xNaMapi - 5, yNaMapi - 5, 10, 10);
                if (pictureBox1.BackColor.R > 100 && pictureBox1.BackColor.R > 100 && pictureBox1.BackColor.R > 100)
                {
                    g.DrawString("NOVI", fontKojiKoristim, textBrushDark, xNaMapi, yNaMapi + 5);
                }
                else
                {
                    g.DrawString("NOVI", fontKojiKoristim, textBrushLight, xNaMapi, yNaMapi + 5);
                }
            }

            // reset dijkstra Brids
            foreach (Brid br in Plan.skupBridova.Values)
            {
                br.isDioPuta = false;
            }

        }

        private void GumbSmanji_Click(object sender, EventArgs e)
        {
            double razlikaHorizontalno = 0.125 * (xdesni - xlijevi);
            xlijevi -= razlikaHorizontalno;
            xdesni += razlikaHorizontalno;

            double razlikaVertikalno = 0.125 * (ydonji - ygornji);
            ygornji -= razlikaVertikalno;
            ydonji += razlikaVertikalno;

            pictureBox1.Refresh();
        }

        private void GumbPovecaj_Click(object sender, EventArgs e)
        {
            double razlikaHorizontalno = 0.125 * (xdesni - xlijevi);
            xlijevi += razlikaHorizontalno;
            xdesni -= razlikaHorizontalno;

            double razlikaVertikalno = 0.125 * (ydonji - ygornji);
            ygornji += razlikaVertikalno;
            ydonji -= razlikaVertikalno;

            pictureBox1.Refresh();
        }

        private void GumbLijevo_Click(object sender, EventArgs e)
        {
            double razlikaHorizontalno = 0.125 * (xdesni - xlijevi);
            xlijevi -= razlikaHorizontalno;
            xdesni -= razlikaHorizontalno;

            pictureBox1.Refresh();
        }

        private void GumbDesno_Click(object sender, EventArgs e)
        {
            double razlikaHorizontalno = 0.125 * (xdesni - xlijevi);
            xlijevi += razlikaHorizontalno;
            xdesni += razlikaHorizontalno;

            pictureBox1.Refresh();
        }

        private void GumbGore_Click(object sender, EventArgs e)
        {
            double razlikaVertikalno = 0.125 * (ydonji - ygornji);
            ygornji -= razlikaVertikalno;
            ydonji -= razlikaVertikalno;

            pictureBox1.Refresh();
        }

        private void GumbDolje_Click(object sender, EventArgs e)
        {
            double razlikaVertikalno = 0.125 * (ydonji - ygornji);
            ygornji += razlikaVertikalno;
            ydonji += razlikaVertikalno;

            pictureBox1.Refresh();
        }
    }
}
