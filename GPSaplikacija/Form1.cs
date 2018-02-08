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
        private Font fontKojiKoristim = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10);

        public Form1()
        {
            InitializeComponent();
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


        private Label unosČvoraNaslov = new Label();
        private Label tekstX = new Label();
        private Label tekstY = new Label();
        private TextBox unosČvoraX = new TextBox();
        private TextBox unosČvoraY = new TextBox();
        private Button dodajČvor = new Button();
        private Button dodajČvorOdustani = new Button();

        private void čvorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(unosČvoraNaslov);
            unosČvoraNaslov.Text = "Unesite koordinate novog čvora ili kliknite na mapu.";
            unosČvoraNaslov.Font = fontKojiKoristim;
            unosČvoraNaslov.AutoSize = true;
            unosČvoraNaslov.Location = new Point(10, 5);

            panelSaKontrolama.Controls.Add(tekstX);
            tekstX.Text = "x: ";
            tekstX.AutoSize = true;
            tekstX.Font = fontKojiKoristim;
            tekstX.Location = new Point(50, 30);

            panelSaKontrolama.Controls.Add(tekstY);
            tekstY.Text = "y: ";
            tekstY.Font = fontKojiKoristim;
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

        private Label odabirPočetnog = new Label();
        private Label odabirZavršnog = new Label();

        private Label odabraniPočetniObavijest = new Label();
        private Label odabraniZavršniObavijest = new Label();

        private Label unesiteVrijeme = new Label();

        private Label unesiteSateObavijest = new Label();
        private Label unesiteMinuteObavijest = new Label();
        private Label unesiteSekundeObavijest = new Label();

        private TextBox unosVremenaSat = new TextBox();
        private TextBox unosVremenaMinuta = new TextBox();
        private TextBox unosVremenaSekundi = new TextBox();

        private Button dodajBrid = new Button();
        private Button dodajBridOdustani = new Button();

        private void bridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Text = "Odaberite početni čvor. (LIJEVI KLIK)";
            odabirPočetnog.Location = new Point(5, 10);
            odabirPočetnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Text = "Odaberite završni čvor. (DESNI KLIK)";
            odabirZavršnog.Location = new Point(400, 10);
            odabirZavršnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniPočetniObavijest.Location = new Point(25, 30);
            odabraniPočetniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniZavršniObavijest.Location = new Point(420, 30);
            odabraniZavršniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unesiteVrijeme);
            unesiteVrijeme.Text = "Unesite vrijeme: ";
            unesiteVrijeme.Location = new Point(10, 60);
            unesiteVrijeme.AutoSize = true;

            panelSaKontrolama.Controls.Add(unosVremenaSat);
            unosVremenaSat.Location = new Point(100, 60);

            panelSaKontrolama.Controls.Add(unesiteSateObavijest);
            unesiteSateObavijest.Text = "h";
            unesiteSateObavijest.Location = new Point(200, 60);
            unesiteSateObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unosVremenaMinuta);
            unosVremenaMinuta.Location = new Point(220, 60);

            panelSaKontrolama.Controls.Add(unesiteMinuteObavijest);
            unesiteMinuteObavijest.Text = "m";
            unesiteMinuteObavijest.Location = new Point(320, 60);
            unesiteMinuteObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unosVremenaSekundi);
            unosVremenaSekundi.Location = new Point(340, 60);

            panelSaKontrolama.Controls.Add(unesiteSekundeObavijest);
            unesiteSekundeObavijest.Text = "s";
            unesiteSekundeObavijest.Location = new Point(440, 60);
            unesiteSekundeObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(dodajBrid);
            dodajBrid.Text = "DODAJ";
            dodajBrid.Location = new Point(700, 30);

            panelSaKontrolama.Controls.Add(dodajBridOdustani);
            dodajBridOdustani.Text = "ODUSTANI";
            dodajBridOdustani.Location = new Point(700, 60);
        }
    }
}
