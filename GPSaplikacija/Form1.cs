using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GPSaplikacija
{
    public partial class Form1 : Form
    {
        private Font fontKojiKoristim = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10);

        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Point p = ((PictureBox)sender).PointToClient(Cursor.Position);
            koordinatePokazivaca.Text = "(" + Skaliraj(p.X,0,pictureBox1.Width,xlijevi,xdesni).ToString("F2",CultureInfo.GetCultureInfo("en-US")) + "," +
                                              Skaliraj(p.Y,0,pictureBox1.Height,ygornji,ydonji).ToString("F2", CultureInfo.GetCultureInfo("en-US")) + ")";
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            koordinatePokazivaca.Text = "";
        }


        private Label labelNaslov = new Label();
        private Label tekstX = new Label();
        private Label tekstY = new Label();
        private TextBox unosČvoraX = new TextBox();
        private TextBox unosČvoraY = new TextBox();
        private Button dodajČvor = new Button();
        private Button gumbOdustani = new Button();

        private void čvorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "Unesite koordinate novog čvora ili kliknite na mapu.";
            labelNaslov.Font = fontKojiKoristim;
            labelNaslov.AutoSize = true;
            labelNaslov.Location = new Point(10, 5);

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

            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Text = "ODUSTANI";
            gumbOdustani.Location = new Point(300, 60);
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

        private void bridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---DODAVANJE NOVOG BRIDA---";
            labelNaslov.Location = new Point(5, 5);
            labelNaslov.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Text = "Odaberite početni čvor. (LIJEVI KLIK)";
            odabirPočetnog.Location = new Point(5, 30);
            odabirPočetnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Text = "Odaberite završni čvor. (DESNI KLIK)";
            odabirZavršnog.Location = new Point(400, 30);
            odabirZavršnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniPočetniObavijest.Location = new Point(25, 50);
            odabraniPočetniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniZavršniObavijest.Location = new Point(420, 50);
            odabraniZavršniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unesiteVrijeme);
            unesiteVrijeme.Text = "Unesite vrijeme: ";
            unesiteVrijeme.Location = new Point(10, 70);
            unesiteVrijeme.AutoSize = true;

            panelSaKontrolama.Controls.Add(unosVremenaSat);
            unosVremenaSat.Location = new Point(100, 70);

            panelSaKontrolama.Controls.Add(unesiteSateObavijest);
            unesiteSateObavijest.Text = "h";
            unesiteSateObavijest.Location = new Point(200, 70);
            unesiteSateObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unosVremenaMinuta);
            unosVremenaMinuta.Location = new Point(220, 70);

            panelSaKontrolama.Controls.Add(unesiteMinuteObavijest);
            unesiteMinuteObavijest.Text = "m";
            unesiteMinuteObavijest.Location = new Point(320, 70);
            unesiteMinuteObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unosVremenaSekundi);
            unosVremenaSekundi.Location = new Point(340, 70);

            panelSaKontrolama.Controls.Add(unesiteSekundeObavijest);
            unesiteSekundeObavijest.Text = "s";
            unesiteSekundeObavijest.Location = new Point(440, 70);
            unesiteSekundeObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(dodajBrid);
            dodajBrid.Text = "DODAJ";
            dodajBrid.Location = new Point(700, 20);

            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Text = "ODUSTANI";
            gumbOdustani.Location = new Point(700, 50);
        }

        private Label unesiteKarakteristikuOpis = new Label();
        private TextBox unešenaKarakteristika = new TextBox();

        private Button označiKarakteristiku = new Button();
        private Button odznačiKarakteristiku = new Button();

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---TRAŽENJE KARAKTERISTIKE---";
            labelNaslov.AutoSize = true;
            labelNaslov.Location = new Point(5, 5);

            panelSaKontrolama.Controls.Add(unesiteKarakteristikuOpis);
            unesiteKarakteristikuOpis.Text = "Unesite karakteristiku koja će biti označena na karti: ";
            unesiteKarakteristikuOpis.AutoSize = true;
            unesiteKarakteristikuOpis.Location = new Point(20, 40);

            panelSaKontrolama.Controls.Add(unešenaKarakteristika);
            unešenaKarakteristika.Location = new Point(300, 40);

            panelSaKontrolama.Controls.Add(označiKarakteristiku);
            označiKarakteristiku.Text = "OZNAČI";
            označiKarakteristiku.Location = new Point(700, 5);

            panelSaKontrolama.Controls.Add(odznačiKarakteristiku);
            odznačiKarakteristiku.Text = "ODZNAČI";
            odznačiKarakteristiku.Location = new Point(700, 35);

            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Text = "ODUSTANI";
            gumbOdustani.Location = new Point(700, 65);
        }


        private Button tražiNajkraći = new Button();

        private void najkraćiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---TRAŽENJE NAJKRAĆEG PUTA---";
            labelNaslov.AutoSize = true;
            labelNaslov.Location = new Point(5, 5);

            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Text = "Odaberite početni čvor. (LIJEVI KLIK)";
            odabirPočetnog.Location = new Point(5, 30);
            odabirPočetnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Text = "Odaberite završni čvor. (DESNI KLIK)";
            odabirZavršnog.Location = new Point(400, 30);
            odabirZavršnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniPočetniObavijest.Location = new Point(25, 50);
            odabraniPočetniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniZavršniObavijest.Location = new Point(420, 50);
            odabraniZavršniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(tražiNajkraći);
            tražiNajkraći.Text = "TRAŽI";
            tražiNajkraći.Location = new Point(700, 20);

            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Text = "ODUSTANI";
            gumbOdustani.Location = new Point(700, 50);
        }

        private Label unesitePosaoOpis = new Label();
        private TextBox unešeniPosao = new TextBox();
        private Button tražiPutUzPosao = new Button();

        private void posaoUsputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelSaKontrolama.Controls.Clear();

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---TRAŽENJE PUTA UZ POSAO---";
            labelNaslov.Location = new Point(5, 5);
            labelNaslov.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Text = "Odaberite početni čvor. (LIJEVI KLIK)";
            odabirPočetnog.Location = new Point(5, 30);
            odabirPočetnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Text = "Odaberite završni čvor. (DESNI KLIK)";
            odabirZavršnog.Location = new Point(400, 30);
            odabirZavršnog.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniPočetniObavijest.Location = new Point(25, 50);
            odabraniPočetniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniZavršniObavijest.Location = new Point(420, 50);
            odabraniZavršniObavijest.AutoSize = true;

            panelSaKontrolama.Controls.Add(unesitePosaoOpis);
            unesitePosaoOpis.Text = "Unesite posao: ";
            unesitePosaoOpis.AutoSize = true;
            unesitePosaoOpis.Location = new Point(20, 70);

            panelSaKontrolama.Controls.Add(unešeniPosao);
            unešeniPosao.Location = new Point(200, 70);

            panelSaKontrolama.Controls.Add(tražiPutUzPosao);
            tražiPutUzPosao.Text = "TRAŽI";
            tražiPutUzPosao.Location = new Point(700, 20);

            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Text = "ODUSTANI";
            gumbOdustani.Location = new Point(700, 50);
        }
    }
}
