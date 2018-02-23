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
using WMPLib;

namespace GPSaplikacija
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        bool glazbaSvira = false;

        private Label labelNaslov = new Label();
        private Label unosČvoraNaslov = new Label();
        private Label tekstX = new Label();
        private Label tekstY = new Label();
        private TextBox unosČvoraX = new TextBox();
        private TextBox unosČvoraY = new TextBox();
        private Label unesiImeNovogČvora = new Label();
        private TextBox unosImenaNovogČvora = new TextBox();
        private Button dodajČvor = new Button();
        private Button gumbOdustani = new Button();
        private Button dodajČvorOdustani = new Button();
        private Label odabirPočetnog = new Label();
        private Label odabirZavršnog = new Label();
        private Label unesiImeNovogBrida = new Label();
        private TextBox unosImenaNovogBrida = new TextBox();
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
        private Label unesiteKarakteristikuOpis = new Label();
        private TextBox unešenaKarakteristika = new TextBox();
        private Button označiKarakteristiku = new Button();
        private Button odznačiKarakteristiku = new Button();
        private Button tražiNajkraći = new Button();
        private Label unesitePosaoOpis = new Label();
        private TextBox unešeniPosao = new TextBox();
        private Button tražiPutUzPosao = new Button();


        private Font fontKojiKoristim = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10);
        private Font fontKojiNeMijenjam = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.Serif), 10);


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


        private void ČvorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OčistiPanel(sender, e);

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "Unesite koordinate novog čvora ili kliknite na mapu.";
            labelNaslov.Location = new Point(10, 5);
            panelSaKontrolama.Controls.Add(tekstX);   
            panelSaKontrolama.Controls.Add(tekstY);
            panelSaKontrolama.Controls.Add(unosČvoraX);
            panelSaKontrolama.Controls.Add(unosČvoraY);
            panelSaKontrolama.Controls.Add(unesiImeNovogČvora);
            panelSaKontrolama.Controls.Add(unosImenaNovogČvora);
            panelSaKontrolama.Controls.Add(dodajČvor);
            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Location = new Point(500, 60);

            uPostupkuDodavanjaČvora = true;
        }



        private void BridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OčistiPanel(sender, e);
            uPostupkuOznačavanjaČvorova = true;

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---DODAVANJE NOVOG BRIDA---";
            labelNaslov.Location = new Point(5, 5);
            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Location = new Point(5, 30);
            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Location = new Point(250, 30);
            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Location = new Point(25, 50);
            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Location = new Point(250, 50);
            panelSaKontrolama.Controls.Add(unesiteVrijeme);
            panelSaKontrolama.Controls.Add(unosVremenaSat);
            panelSaKontrolama.Controls.Add(unesiteSateObavijest);
            panelSaKontrolama.Controls.Add(unosVremenaMinuta);
            panelSaKontrolama.Controls.Add(unesiteMinuteObavijest);
            panelSaKontrolama.Controls.Add(unosVremenaSekundi);
            panelSaKontrolama.Controls.Add(unesiteSekundeObavijest);
            panelSaKontrolama.Controls.Add(unesiImeNovogBrida);
            panelSaKontrolama.Controls.Add(unosImenaNovogBrida);
            panelSaKontrolama.Controls.Add(dodajBrid);
            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Location = new Point(700, 50);
        }



        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            OčistiPanel(sender, e);

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---TRAŽENJE KARAKTERISTIKE---";
            labelNaslov.Location = new Point(5, 5);
            panelSaKontrolama.Controls.Add(unesiteKarakteristikuOpis);
            panelSaKontrolama.Controls.Add(unešenaKarakteristika);
            panelSaKontrolama.Controls.Add(označiKarakteristiku);
            panelSaKontrolama.Controls.Add(odznačiKarakteristiku);
            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Location = new Point(700, 65);
        }




        private void NajkraćiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OčistiPanel(sender, e);
            uPostupkuOznačavanjaČvorova = true;

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---TRAŽENJE NAJKRAĆEG PUTA---";
            labelNaslov.Location = new Point(5, 5);
            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Location = new Point(5, 30);
            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Location = new Point(400, 30);
            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Location = new Point(25, 50);
            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Location = new Point(420, 50);
            panelSaKontrolama.Controls.Add(tražiNajkraći);
            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Location = new Point(700, 50);
        }


        private void PosaoUsputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OčistiPanel(sender, e);
            uPostupkuOznačavanjaČvorova = true;

            panelSaKontrolama.Controls.Add(labelNaslov);
            labelNaslov.Text = "---TRAŽENJE PUTA UZ POSAO---";
            labelNaslov.Location = new Point(5, 5);
            panelSaKontrolama.Controls.Add(odabirPočetnog);
            odabirPočetnog.Location = new Point(5, 30);
            panelSaKontrolama.Controls.Add(odabirZavršnog);
            odabirZavršnog.Location = new Point(400, 30);
            panelSaKontrolama.Controls.Add(odabraniPočetniObavijest);
            odabraniPočetniObavijest.Location = new Point(25, 50);
            panelSaKontrolama.Controls.Add(odabraniZavršniObavijest);
            odabraniZavršniObavijest.Location = new Point(420, 50);
            panelSaKontrolama.Controls.Add(unesitePosaoOpis);
            panelSaKontrolama.Controls.Add(unešeniPosao);
            panelSaKontrolama.Controls.Add(tražiPutUzPosao);
            panelSaKontrolama.Controls.Add(gumbOdustani);
            gumbOdustani.Location = new Point(700, 50);
        }





        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Point p = ((PictureBox)sender).PointToClient(Cursor.Position);
            //prave koordinate:
            double x = Skaliraj(p.X, 0, pictureBox1.Width, xlijevi, xdesni),
                   y = Skaliraj(p.Y, 0, pictureBox1.Height, ygornji, ydonji);


            var ee = e as System.Windows.Forms.MouseEventArgs;

            string najbliziCvor = "", drugiNajbliziCvor = "";
            double najblizaUdaljenost = -1, drugaNajblizaUdaljenost = -1;

            //odredim najbliži čvor i udaljenost od njega
            foreach (var element in Plan.SkupČvorova)
            {
                double izracunamoUdaljenost = (element.Value.X - x) * (element.Value.X - x) + (element.Value.Y - y) * (element.Value.Y - y);
                if (najblizaUdaljenost == -1)
                {
                    najblizaUdaljenost = izracunamoUdaljenost;
                    najbliziCvor = element.Key;
                }
                else if(izracunamoUdaljenost < najblizaUdaljenost)
                {
                    najblizaUdaljenost = izracunamoUdaljenost;
                    najbliziCvor = element.Key;
                }
            }

            //odredim drugi najbliži čvor i udaljenost od njega
            foreach (var element in Plan.SkupČvorova)
            {
                double izracunamoUdaljenost = (element.Value.X - x) * (element.Value.X - x) + (element.Value.Y - y) * (element.Value.Y - y);
                if (drugaNajblizaUdaljenost == -1 && element.Key != najbliziCvor)
                {
                    drugaNajblizaUdaljenost = izracunamoUdaljenost;
                    drugiNajbliziCvor = element.Key;
                }
                else if (izracunamoUdaljenost < drugaNajblizaUdaljenost && element.Key != najbliziCvor)
                {
                    drugaNajblizaUdaljenost = izracunamoUdaljenost;
                    drugiNajbliziCvor = element.Key;
                }
            }

            if (najblizaUdaljenost != -1 && drugaNajblizaUdaljenost != -1)
            {
                if (najblizaUdaljenost * 9 <= drugaNajblizaUdaljenost)
                {
                    if (ee.Button == MouseButtons.Left)
                    {
                        odabraniPočetniObavijest.Text = "- odabrani čvor: " + najbliziCvor;
                    }
                    else if (ee.Button == MouseButtons.Right)
                    {
                        odabraniZavršniObavijest.Text = "- odabrani čvor: " + najbliziCvor;
                    }
                }
            }

            //za unos čvora, popuniti X i Y
            unosČvoraX.Text = x.ToString("F2", CultureInfo.GetCultureInfo("en-US"));
            unosČvoraY.Text = y.ToString("F2", CultureInfo.GetCultureInfo("en-US"));

            budućiČvorX = x;
            budućiČvorY = y;

            if (uPostupkuDodavanjaČvora == true)
            {
                budućiČvorPostoji = true;
            }
            else
            {
                budućiČvorPostoji = false;
            }

            pictureBox1.Refresh();
        }

        private void BojaCesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pBridUnutarnja = new Pen(colorDialog1.Color, 5);
                pictureBox1.Refresh();
            }
        }

        private void BojaČvorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                b = new SolidBrush(colorDialog1.Color);
                pictureBox1.Refresh();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Jeste li sigurni da želite zatvoriti aplikaciju?",
                                         "Zatvaranje GPS-a",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad8: // gore
                    GumbGore_Click(sender, e);
                    break;
                case Keys.NumPad2: // dolje
                    GumbDolje_Click(sender, e);
                    break;
                case Keys.NumPad4: // lijevo
                    GumbLijevo_Click(sender, e);
                    break;
                case Keys.NumPad6: // desno
                    GumbDesno_Click(sender, e);
                    break;
                case Keys.Add: // povećaj
                    GumbPovecaj_Click(sender, e);
                    break;
                case Keys.Subtract: // smanji
                    GumbSmanji_Click(sender, e);
                    break;
            }
        }

        private void dodajČvorPlanu(object sender, EventArgs e)
        {
            budućiČvorPostoji = false;

            System.Globalization.NumberFormatInfo info = new System.Globalization.NumberFormatInfo();
            info.NumberDecimalSeparator = ".";
            info.NumberGroupSeparator = ",";
            double x = 0;
            double y = 0;

            try
            {
                x = Convert.ToDouble(unosČvoraX.Text, info);
                y = Convert.ToDouble(unosČvoraY.Text, info);
            }
            catch
            {
                MessageBox.Show("Krivi format koordinata! (Za početak provjerite jeste li ih sve unijeli!)",
                    "Krivi format", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Stop);
                return;
            }

            if(unosImenaNovogČvora.Text == "")
            {
                MessageBox.Show("Niste unijeli ime novog čvora! Molimo unesite neko.", 
                    "Nema imena", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Stop);
                return;
            }

            int status = Plan.DodajČvor(x, y, unosImenaNovogČvora.Text);
            if(status == -1)
            {
                MessageBox.Show("Već postoji čvor s takvim imenom! Molimo odaberite neko drugo.", 
                    "Ime čvora zauzeto", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            else if(status == -2)
            {
                MessageBox.Show("Već postoji čvor na tim koordinatama! Molimo odaberite neku drugu koordinatu.",
                    "Zauzete koordinate",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if(status == 1)
            {
                MessageBox.Show("Uspješno dodan čvor " + unosImenaNovogČvora.Text 
                        + ", na koordinate (" + Convert.ToDouble(unosČvoraX.Text) 
                        + "," + Convert.ToDouble(unosČvoraY.Text) + ")",
                    "Uspješno dodan čvor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            pictureBox1.Refresh();
        }


        private void DodajBridPlanu(object sender, EventArgs e)
        {
            string defaultni = "- odabrani čvor: ";

            if (unosVremenaSat.Text == "")
            {
                MessageBox.Show("Niste unijeli sat!", "Unesite ispravno vrijeme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (unosVremenaMinuta.Text == "")
            {
                MessageBox.Show("Niste unijeli minute!", "Unesite ispravno vrijeme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (unosVremenaSekundi.Text == "")
            {
                MessageBox.Show("Niste unijeli sekunde!", "Unesite ispravno vrijeme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double vrijeme = 0;

                try {
                    vrijeme = Convert.ToDouble(unosVremenaSat.Text) * 3600
                    + Convert.ToDouble(unosVremenaMinuta.Text) * 60
                    + Convert.ToDouble(unosVremenaSekundi.Text);
                } catch
                {
                    MessageBox.Show("Nije dozvoljen format vremena!", "Greška u vremenu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string naziv = unosImenaNovogBrida.Text;
                if (naziv == "")
                {
                    MessageBox.Show("Niste unijeli ime novog brida!", "Unesite ime brida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (odabraniPočetniObavijest.Text.Substring(defaultni.Length) == "xxxxxxxxxx")
                {
                    MessageBox.Show("Niste odabrali početni vrh!", "Odaberite početni vrh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (odabraniZavršniObavijest.Text.Substring(defaultni.Length) == "xxxxxxxxxx")
                {
                    MessageBox.Show("Niste odabrali završni vrh!", "Odaberite završni vrh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string poruka = Plan.DodajBrid(naziv, odabraniPočetniObavijest.Text.Substring(defaultni.Length), odabraniZavršniObavijest.Text.Substring(defaultni.Length), vrijeme);
                    MessageBox.Show(poruka, "Poruka", MessageBoxButtons.OK);
                }
            }

            pictureBox1.Refresh();
        }





        private void OčistiPanel(object sender, EventArgs e)
        {
            uPostupkuDodavanjaČvora = false;
            budućiČvorPostoji = false;
            uPostupkuOznačavanjaČvorova = false;

            panelSaKontrolama.Controls.Clear();
            unosČvoraX.Text = "";
            unosČvoraY.Text = "";
            unosImenaNovogČvora.Text = "";
            unosVremenaSat.Text = "";
            unosVremenaMinuta.Text = "";
            unosVremenaSekundi.Text = "";
            unešenaKarakteristika.Text = "";
            unešeniPosao.Text = "";
            unosImenaNovogBrida.Text = "";
            odabraniPočetniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniZavršniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";

            pictureBox1.Refresh();
        }


        private void DijkstraTest(object sender, EventArgs e)
        {
            String s1 = odabraniPočetniObavijest.Text;
            String s2 = odabraniZavršniObavijest.Text;
            int l1 = "- odabrani čvor: ".Length;
            s1 = s1.Substring(l1);
            s2 = s2.Substring(l1);

            Plan.nadiNajkraciPut(s1,s2);

            pictureBox1.Refresh();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            labelNaslov.AutoSize = true;
            labelNaslov.Font = fontKojiNeMijenjam;

            tekstX.Text = "x: ";
            tekstX.AutoSize = true;
            tekstX.Font = fontKojiNeMijenjam;
            tekstX.Location = new Point(50, 30);

            tekstY.Text = "y: ";
            tekstY.Font = fontKojiNeMijenjam;
            tekstY.AutoSize = true;
            tekstY.Location = new Point(50, 60);

            unesiImeNovogČvora.Text = "Unesi ime novog čvora:";
            unesiImeNovogČvora.Font = fontKojiNeMijenjam;
            unesiImeNovogČvora.AutoSize = true;
            unesiImeNovogČvora.Location = new Point(250, 30);

            unosČvoraX.Location = new Point(80, 30);
            unosČvoraX.Text = "";

            unosČvoraY.Location = new Point(80, 60);
            unosČvoraY.Text = "";

            unosImenaNovogČvora.Location = new Point(250, 60);
            unosImenaNovogČvora.Text = "";

            dodajČvor.Text = "DODAJ";
            dodajČvor.Location = new Point(500, 30);
            dodajČvor.Click += dodajČvorPlanu;

            gumbOdustani.Text = "ODUSTANI";
            gumbOdustani.Click += OčistiPanel;

            unesiImeNovogBrida.Text = "Unesi ime novog brida:";
            unesiImeNovogBrida.Font = fontKojiNeMijenjam;
            unesiImeNovogBrida.AutoSize = true;
            unesiImeNovogBrida.Location = new Point(500, 20);

            unosImenaNovogBrida.Location = new Point(500, 45);
            unosImenaNovogBrida.Width = 160;
            unosImenaNovogBrida.Text = "";

            odabirPočetnog.AutoSize = true;
            odabirPočetnog.Text = "Odaberite početni čvor. (LIJEVI KLIK)";

            odabirZavršnog.Text = "Odaberite završni čvor. (DESNI KLIK)";
            odabirZavršnog.AutoSize = true;

            odabraniPočetniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniPočetniObavijest.AutoSize = true;
            odabraniPočetniObavijest.ForeColor = Color.Blue;

            odabraniZavršniObavijest.Text = "- odabrani čvor: xxxxxxxxxx";
            odabraniZavršniObavijest.AutoSize = true;
            odabraniZavršniObavijest.ForeColor = Color.Red;

            unesiteVrijeme.Text = "Unesite vrijeme: ";
            unesiteVrijeme.Location = new Point(10, 73);
            unesiteVrijeme.AutoSize = true;

            unosVremenaSat.Location = new Point(100, 70);
            unosVremenaSat.Text = "";

            unesiteSateObavijest.Text = "h";
            unesiteSateObavijest.Location = new Point(200, 73);
            unesiteSateObavijest.AutoSize = true;

            unosVremenaMinuta.Location = new Point(220, 70);
            unosVremenaMinuta.Text = "";

            unesiteMinuteObavijest.Text = "m";
            unesiteMinuteObavijest.Location = new Point(320, 73);
            unesiteMinuteObavijest.AutoSize = true;

            unosVremenaSekundi.Location = new Point(340, 70);
            unosVremenaSekundi.Text = "";

            unesiteSekundeObavijest.Text = "s";
            unesiteSekundeObavijest.Location = new Point(440, 73);
            unesiteSekundeObavijest.AutoSize = true;

            dodajBrid.Text = "DODAJ";
            dodajBrid.Location = new Point(700, 20);
            dodajBrid.Click += DodajBridPlanu;

            unesiteKarakteristikuOpis.Text = "Unesite karakteristiku koja će biti označena na karti: ";
            unesiteKarakteristikuOpis.AutoSize = true;
            unesiteKarakteristikuOpis.Location = new Point(20, 40);

            unešenaKarakteristika.Location = new Point(300, 40);
            unešenaKarakteristika.Text = "";

            označiKarakteristiku.Text = "OZNAČI";
            označiKarakteristiku.Location = new Point(700, 5);

            odznačiKarakteristiku.Text = "ODZNAČI";
            odznačiKarakteristiku.Location = new Point(700, 35);

            tražiNajkraći.Text = "TRAŽI";
            tražiNajkraći.Location = new Point(700, 20);
            tražiNajkraći.Click += DijkstraTest;

            unesitePosaoOpis.Text = "Unesite posao: ";
            unesitePosaoOpis.AutoSize = true;
            unesitePosaoOpis.Location = new Point(20, 70);

            unešeniPosao.Location = new Point(200, 70);
            unešeniPosao.Text = "";

            tražiPutUzPosao.Text = "TRAŽI";
            tražiPutUzPosao.Location = new Point(700, 20);
        }

        private void spremanjeSnimkeZaslona_Click(object sender, EventArgs e)
        {
            Bitmap memoryImage;
            //slika je dimenzija koje ima forma (jer želimo snimak forme)
            memoryImage = new Bitmap(this.Width, this.Height);
            Size s = new Size(memoryImage.Width, memoryImage.Height);

            //stvaranje grafike
            Console.WriteLine("Stvaranje Graphicsa...");
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            //spremanje podataka sa ekrana - od gornjeg lijevog ruba forme u sliku od (0,0) (s je veličina)
            Console.WriteLine("Kopiranje podataka sa ekrana...");
            memoryGraphics.CopyFromScreen(this.Left, this.Top, 0, 0, s);

            //spremanje u datoteku
            Console.WriteLine("Spremanje snimke zaslona...");

            saveFileDialog1.Filter = "Jpeg Format Slike|*.jpg|Bitmap Format Slike|*.bmp|Gif Format Slike|*.gif";
            saveFileDialog1.Title = "Spremi snimku zaslona";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                //Sprema sliku kroz FileStream stvoren OpenFile metodom  
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                //sprema sliku u odabranom ImageFormat-u koji je korisnik u DialogBoxu odabrao    
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        memoryImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        memoryImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        memoryImage.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
            Console.WriteLine("Snimka zaslona uspješno spremljena...");
        }

        private void formaPozadinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor = colorDialog1.Color;
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void odaberiFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pokaži prozor za odabir fonta.
            DialogResult result = fontDialog1.ShowDialog();
            //Pogledaj je lo OK pritisnut.
            if (result == DialogResult.OK)
            {
                //Dohvati font.
                Font font = fontDialog1.Font;
                //Postavi svojstva forme.
                fontKojiKoristim = font;

                pictureBox1.Refresh();
            }
        }

        private void svirajNeštoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(glazbaSvira == false)
            {
                try
                {
                    player.URL = "Ikson-Remember.mp3";
                    player.controls.play();
                    glazbaSvira = true;
                }
                catch
                {
                    MessageBox.Show("Ne mogu naći glazbenu datoteku!", "Nema datoteke!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                sviranje.Text = "Zaustavi glazbu";
            }
            else if(glazbaSvira == true)
            {
                player.controls.stop();
                glazbaSvira = false;

                sviranje.Text = "Sviraj nešto";
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
