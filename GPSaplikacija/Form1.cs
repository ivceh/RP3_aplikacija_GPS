using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSaplikacija
{
    public partial class Form1 : Form
    {
        private Label unosČvoraNaslov = new Label();
        private Label tekstX = new Label();
        private Label tekstY = new Label();
        private TextBox unosČvoraX = new TextBox();
        private TextBox unosČvoraY = new TextBox();
        private Button dodajČvor = new Button();
        private Button dodajČvorOdustani = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);
            Brush b = new SolidBrush(Color.LightYellow);

            //g.DrawLine(p, 0, 0, 100, 100);
            //g.DrawEllipse(p, 50, 100, 100, 100);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = ((PictureBox)sender).PointToClient(Cursor.Position);
            koordinatePokazivaca.Text = "(" + p.X + "," + p.Y + ")";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            koordinatePokazivaca.Text = "";
        }

        private void čvorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();
            panelSaKontrolama.Controls.Add(unosČvoraNaslov);
            unosČvoraNaslov.Text = "Unesite koordinate novog čvora ili kliknite na mapu.";
            unosČvoraNaslov.AutoSize = true;
            unosČvoraNaslov.Location = new Point(0, 0);

            panelSaKontrolama.Controls.Add(tekstX);
            tekstX.Text = "x: ";
            tekstX.AutoSize = true;
            tekstX.Location = new Point(50, 30);

            panelSaKontrolama.Controls.Add(tekstY);
            tekstY.Text = "y: ";
            tekstY.AutoSize = true;
            tekstY.Location = new Point(50, 60);

            panelSaKontrolama.Controls.Add(unosČvoraX);
            unosČvoraX.Location = new Point(80, 30);

            panelSaKontrolama.Controls.Add(unosČvoraY);
            unosČvoraY.Location = new Point(80, 60);

            panelSaKontrolama.Controls.Add(dodajČvor);
            dodajČvor.Text = "DODAJ";
            dodajČvor.Location = new Point(300, 30);

            panelSaKontrolama.Controls.Add(dodajČvorOdustani);
            dodajČvorOdustani.Text = "ODUSTANI";
            dodajČvorOdustani.Location = new Point(300, 60);
        }
    }
}
