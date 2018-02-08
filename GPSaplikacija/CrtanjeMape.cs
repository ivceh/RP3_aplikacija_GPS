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
        // koordinate dijela koji mapa prikazuje
        double xlijevi = 0, xdesni = 0, ygornji = 1000, ydonji = 1000;

        // skalira x iz intervala [minx, maxx] na interval [miny, maxy]
        static double Skaliraj (double x, double minx, double maxx, double miny, double maxy)
        {
            return (x - minx) / (maxx - minx) * (maxy - miny) + miny;
        }

        // obrubi i sjenčanja
        Pen pVanjska = new Pen(Color.Black, 7), pUnutarnja = new Pen(Color.LightYellow, 5);
        Brush b = new SolidBrush(Color.LightYellow);

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (Pen p in new Pen[]{pVanjska, pUnutarnja})
            {
                foreach (Brid b in Plan.SkupBridova)
                {
                    Čvor cp = b.PočetniČvor, cz = b.ZavršniČvor;

                    float xpNaMapi, ypNaMapi, xzNaMapi, yzNaMapi;
                    xpNaMapi = (float)Skaliraj(cp.X, xlijevi, xdesni, 0, pictureBox1.Width);
                    ypNaMapi = (float)Skaliraj(cp.Y, ygornji, ydonji, 0, pictureBox1.Height);
                    xzNaMapi = (float)Skaliraj(cz.X, xlijevi, xdesni, 0, pictureBox1.Width);
                    yzNaMapi = (float)Skaliraj(cz.Y, ygornji, ydonji, 0, pictureBox1.Height);

                    g.DrawLine(p, xpNaMapi, ypNaMapi, xzNaMapi, yzNaMapi);
                }
            }
        }
    }
}
