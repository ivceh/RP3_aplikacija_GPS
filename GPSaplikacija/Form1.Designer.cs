namespace GPSaplikacija
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.koordinatePokazivaca = new System.Windows.Forms.Label();
            this.tableLayoutPanelDesni = new System.Windows.Forms.TableLayoutPanel();
            this.gumbSmanji = new System.Windows.Forms.Button();
            this.gumbPovecaj = new System.Windows.Forms.Button();
            this.tableLayoutPanelStrelice = new System.Windows.Forms.TableLayoutPanel();
            this.gumbGore = new System.Windows.Forms.Button();
            this.gumbLijevo = new System.Windows.Forms.Button();
            this.gumbDesno = new System.Windows.Forms.Button();
            this.gumbDolje = new System.Windows.Forms.Button();
            this.labelOpis = new System.Windows.Forms.Label();
            this.panelSaKontrolama = new System.Windows.Forms.Panel();
            this.vrijeme = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.čvorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.najkraćiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posaoUsputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.OdaberiBoje = new System.Windows.Forms.ToolStripDropDownButton();
            this.bojaCesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bojaČvorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.formaPozadinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.odaberiFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.sviranje = new System.Windows.Forms.ToolStripMenuItem();
            this.spremanjeSnimkeZaslona = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelDesni.SuspendLayout();
            this.tableLayoutPanelStrelice.SuspendLayout();
            this.panelSaKontrolama.SuspendLayout();
            this.Dodaj.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.koordinatePokazivaca, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelDesni, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelSaKontrolama, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1030, 507);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(818, 374);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // koordinatePokazivaca
            // 
            this.koordinatePokazivaca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.koordinatePokazivaca.AutoSize = true;
            this.koordinatePokazivaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.koordinatePokazivaca.Location = new System.Drawing.Point(927, 443);
            this.koordinatePokazivaca.Name = "koordinatePokazivaca";
            this.koordinatePokazivaca.Size = new System.Drawing.Size(0, 25);
            this.koordinatePokazivaca.TabIndex = 1;
            this.koordinatePokazivaca.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tableLayoutPanelDesni
            // 
            this.tableLayoutPanelDesni.ColumnCount = 2;
            this.tableLayoutPanelDesni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDesni.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDesni.Controls.Add(this.gumbSmanji, 0, 0);
            this.tableLayoutPanelDesni.Controls.Add(this.gumbPovecaj, 1, 0);
            this.tableLayoutPanelDesni.Controls.Add(this.tableLayoutPanelStrelice, 0, 1);
            this.tableLayoutPanelDesni.Controls.Add(this.labelOpis, 0, 2);
            this.tableLayoutPanelDesni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDesni.Location = new System.Drawing.Point(827, 28);
            this.tableLayoutPanelDesni.Name = "tableLayoutPanelDesni";
            this.tableLayoutPanelDesni.RowCount = 3;
            this.tableLayoutPanelDesni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelDesni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanelDesni.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanelDesni.Size = new System.Drawing.Size(200, 374);
            this.tableLayoutPanelDesni.TabIndex = 2;
            // 
            // gumbSmanji
            // 
            this.gumbSmanji.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbSmanji.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gumbSmanji.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbSmanji.BackgroundImage")));
            this.gumbSmanji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbSmanji.Cursor = System.Windows.Forms.Cursors.Default;
            this.gumbSmanji.Location = new System.Drawing.Point(15, 3);
            this.gumbSmanji.Name = "gumbSmanji";
            this.gumbSmanji.Size = new System.Drawing.Size(70, 50);
            this.gumbSmanji.TabIndex = 0;
            this.gumbSmanji.UseVisualStyleBackColor = false;
            this.gumbSmanji.Click += new System.EventHandler(this.GumbSmanji_Click);
            // 
            // gumbPovecaj
            // 
            this.gumbPovecaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbPovecaj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gumbPovecaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbPovecaj.BackgroundImage")));
            this.gumbPovecaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbPovecaj.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gumbPovecaj.Location = new System.Drawing.Point(115, 3);
            this.gumbPovecaj.Name = "gumbPovecaj";
            this.gumbPovecaj.Size = new System.Drawing.Size(70, 50);
            this.gumbPovecaj.TabIndex = 1;
            this.gumbPovecaj.UseVisualStyleBackColor = false;
            this.gumbPovecaj.Click += new System.EventHandler(this.GumbPovecaj_Click);
            // 
            // tableLayoutPanelStrelice
            // 
            this.tableLayoutPanelStrelice.ColumnCount = 3;
            this.tableLayoutPanelDesni.SetColumnSpan(this.tableLayoutPanelStrelice, 2);
            this.tableLayoutPanelStrelice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStrelice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStrelice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStrelice.Controls.Add(this.gumbGore, 1, 0);
            this.tableLayoutPanelStrelice.Controls.Add(this.gumbLijevo, 0, 1);
            this.tableLayoutPanelStrelice.Controls.Add(this.gumbDesno, 2, 1);
            this.tableLayoutPanelStrelice.Controls.Add(this.gumbDolje, 1, 2);
            this.tableLayoutPanelStrelice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStrelice.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanelStrelice.Name = "tableLayoutPanelStrelice";
            this.tableLayoutPanelStrelice.RowCount = 3;
            this.tableLayoutPanelStrelice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStrelice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStrelice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStrelice.Size = new System.Drawing.Size(194, 143);
            this.tableLayoutPanelStrelice.TabIndex = 2;
            // 
            // gumbGore
            // 
            this.gumbGore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbGore.BackgroundImage")));
            this.gumbGore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbGore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gumbGore.Location = new System.Drawing.Point(67, 3);
            this.gumbGore.Name = "gumbGore";
            this.gumbGore.Size = new System.Drawing.Size(58, 41);
            this.gumbGore.TabIndex = 0;
            this.gumbGore.UseVisualStyleBackColor = true;
            this.gumbGore.Click += new System.EventHandler(this.GumbGore_Click);
            // 
            // gumbLijevo
            // 
            this.gumbLijevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbLijevo.BackgroundImage")));
            this.gumbLijevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbLijevo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gumbLijevo.Location = new System.Drawing.Point(3, 50);
            this.gumbLijevo.Name = "gumbLijevo";
            this.gumbLijevo.Size = new System.Drawing.Size(58, 41);
            this.gumbLijevo.TabIndex = 1;
            this.gumbLijevo.UseVisualStyleBackColor = true;
            this.gumbLijevo.Click += new System.EventHandler(this.GumbLijevo_Click);
            // 
            // gumbDesno
            // 
            this.gumbDesno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbDesno.BackgroundImage")));
            this.gumbDesno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbDesno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gumbDesno.Location = new System.Drawing.Point(131, 50);
            this.gumbDesno.Name = "gumbDesno";
            this.gumbDesno.Size = new System.Drawing.Size(60, 41);
            this.gumbDesno.TabIndex = 2;
            this.gumbDesno.UseVisualStyleBackColor = true;
            this.gumbDesno.Click += new System.EventHandler(this.GumbDesno_Click);
            // 
            // gumbDolje
            // 
            this.gumbDolje.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbDolje.BackgroundImage")));
            this.gumbDolje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbDolje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gumbDolje.Location = new System.Drawing.Point(67, 97);
            this.gumbDolje.Name = "gumbDolje";
            this.gumbDolje.Size = new System.Drawing.Size(58, 43);
            this.gumbDolje.TabIndex = 3;
            this.gumbDolje.UseVisualStyleBackColor = true;
            this.gumbDolje.Click += new System.EventHandler(this.GumbDolje_Click);
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanelDesni.SetColumnSpan(this.labelOpis, 2);
            this.labelOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOpis.Location = new System.Drawing.Point(3, 205);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(194, 169);
            this.labelOpis.TabIndex = 3;
            this.labelOpis.Text = "Klikom na čvor ili brid ovdje se pojavljuje opis.";
            this.labelOpis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSaKontrolama
            // 
            this.panelSaKontrolama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaKontrolama.Controls.Add(this.vrijeme);
            this.panelSaKontrolama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaKontrolama.Location = new System.Drawing.Point(3, 408);
            this.panelSaKontrolama.Name = "panelSaKontrolama";
            this.panelSaKontrolama.Size = new System.Drawing.Size(818, 96);
            this.panelSaKontrolama.TabIndex = 3;
            // 
            // vrijeme
            // 
            this.vrijeme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.vrijeme.AutoSize = true;
            this.vrijeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vrijeme.ForeColor = System.Drawing.Color.Black;
            this.vrijeme.Location = new System.Drawing.Point(357, 34);
            this.vrijeme.Name = "vrijeme";
            this.vrijeme.Size = new System.Drawing.Size(0, 26);
            this.vrijeme.TabIndex = 0;
            this.vrijeme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dodaj
            // 
            this.Dodaj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.OdaberiBoje,
            this.spremanjeSnimkeZaslona});
            this.Dodaj.Location = new System.Drawing.Point(0, 0);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(1030, 25);
            this.Dodaj.TabIndex = 1;
            this.Dodaj.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.čvorToolStripMenuItem,
            this.bridToolStripMenuItem});
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "&Dodaj";
            this.toolStripButton1.ToolTipText = "Dodajte brid ili čvor trenutnom planu.";
            // 
            // čvorToolStripMenuItem
            // 
            this.čvorToolStripMenuItem.Name = "čvorToolStripMenuItem";
            this.čvorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.čvorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.čvorToolStripMenuItem.Text = "Čvor";
            this.čvorToolStripMenuItem.ToolTipText = "Dodajte čvor trenutnom planu.";
            this.čvorToolStripMenuItem.Click += new System.EventHandler(this.ČvorToolStripMenuItem_Click);
            // 
            // bridToolStripMenuItem
            // 
            this.bridToolStripMenuItem.Name = "bridToolStripMenuItem";
            this.bridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bridToolStripMenuItem.Text = "Brid";
            this.bridToolStripMenuItem.ToolTipText = "Dodajte brid trenutnom planu.";
            this.bridToolStripMenuItem.Click += new System.EventHandler(this.BridToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.najkraćiToolStripMenuItem,
            this.posaoUsputToolStripMenuItem});
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton2.Text = "&Nađi put";
            this.toolStripButton2.ToolTipText = "Pronađite put između polazne i željene lokacije.";
            // 
            // najkraćiToolStripMenuItem
            // 
            this.najkraćiToolStripMenuItem.Name = "najkraćiToolStripMenuItem";
            this.najkraćiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.najkraćiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.najkraćiToolStripMenuItem.Text = "Najkraći";
            this.najkraćiToolStripMenuItem.ToolTipText = "Pronađite najkraći put i stignite brzo na željeno odredište.";
            this.najkraćiToolStripMenuItem.Click += new System.EventHandler(this.NajkraćiToolStripMenuItem_Click);
            // 
            // posaoUsputToolStripMenuItem
            // 
            this.posaoUsputToolStripMenuItem.Name = "posaoUsputToolStripMenuItem";
            this.posaoUsputToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.posaoUsputToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.posaoUsputToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.posaoUsputToolStripMenuItem.Text = "Posao usput";
            this.posaoUsputToolStripMenuItem.ToolTipText = "Pronađite najkraći put, ali tako da pritom obavite predviđeni posao.";
            this.posaoUsputToolStripMenuItem.Click += new System.EventHandler(this.PosaoUsputToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "&Pronađi";
            this.toolStripButton3.ToolTipText = "Pronađite čvorove i/ili bridove sa željenom karakteristikom.";
            this.toolStripButton3.Click += new System.EventHandler(this.ToolStripButton3_Click);
            // 
            // OdaberiBoje
            // 
            this.OdaberiBoje.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OdaberiBoje.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bojaCesteToolStripMenuItem,
            this.bojaČvorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.formaPozadinaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.odaberiFontToolStripMenuItem,
            this.toolStripMenuItem3,
            this.sviranje});
            this.OdaberiBoje.Image = ((System.Drawing.Image)(resources.GetObject("OdaberiBoje.Image")));
            this.OdaberiBoje.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OdaberiBoje.Name = "OdaberiBoje";
            this.OdaberiBoje.Size = new System.Drawing.Size(89, 22);
            this.OdaberiBoje.Text = "P&ersonaliziraj";
            this.OdaberiBoje.ToolTipText = "Personalizirajte aplikaciju.";
            // 
            // bojaCesteToolStripMenuItem
            // 
            this.bojaCesteToolStripMenuItem.Name = "bojaCesteToolStripMenuItem";
            this.bojaCesteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.bojaCesteToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.bojaCesteToolStripMenuItem.Text = "Boja ceste";
            this.bojaCesteToolStripMenuItem.ToolTipText = "Odaberite boju kojom se crtaju bridovi.";
            this.bojaCesteToolStripMenuItem.Click += new System.EventHandler(this.BojaCesteToolStripMenuItem_Click);
            // 
            // bojaČvorToolStripMenuItem
            // 
            this.bojaČvorToolStripMenuItem.Name = "bojaČvorToolStripMenuItem";
            this.bojaČvorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.bojaČvorToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.bojaČvorToolStripMenuItem.Text = "Boja čvora";
            this.bojaČvorToolStripMenuItem.ToolTipText = "Odaberite boju kojom se crtaju čvorovi.";
            this.bojaČvorToolStripMenuItem.Click += new System.EventHandler(this.BojaČvorToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(237, 6);
            // 
            // formaPozadinaToolStripMenuItem
            // 
            this.formaPozadinaToolStripMenuItem.Name = "formaPozadinaToolStripMenuItem";
            this.formaPozadinaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.formaPozadinaToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.formaPozadinaToolStripMenuItem.Text = "Forma - pozadina";
            this.formaPozadinaToolStripMenuItem.ToolTipText = "Odaberite boju pozadine plana.";
            this.formaPozadinaToolStripMenuItem.Click += new System.EventHandler(this.FormaPozadinaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(237, 6);
            // 
            // odaberiFontToolStripMenuItem
            // 
            this.odaberiFontToolStripMenuItem.Name = "odaberiFontToolStripMenuItem";
            this.odaberiFontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.odaberiFontToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.odaberiFontToolStripMenuItem.Text = "Odaberi font";
            this.odaberiFontToolStripMenuItem.ToolTipText = "Odaberite font za nazive čvorova i bridova.";
            this.odaberiFontToolStripMenuItem.Click += new System.EventHandler(this.OdaberiFontToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(237, 6);
            // 
            // sviranje
            // 
            this.sviranje.Name = "sviranje";
            this.sviranje.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.sviranje.Size = new System.Drawing.Size(240, 22);
            this.sviranje.Text = "Sviraj nešto";
            this.sviranje.ToolTipText = "Pustite si malo glazbe dok se zabavljate u našoj aplikaciji.";
            this.sviranje.Click += new System.EventHandler(this.SvirajNeštoToolStripMenuItem_Click);
            // 
            // spremanjeSnimkeZaslona
            // 
            this.spremanjeSnimkeZaslona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.spremanjeSnimkeZaslona.Image = ((System.Drawing.Image)(resources.GetObject("spremanjeSnimkeZaslona.Image")));
            this.spremanjeSnimkeZaslona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.spremanjeSnimkeZaslona.Name = "spremanjeSnimkeZaslona";
            this.spremanjeSnimkeZaslona.Size = new System.Drawing.Size(92, 22);
            this.spremanjeSnimkeZaslona.Text = "&Snimka zaslona";
            this.spremanjeSnimkeZaslona.ToolTipText = "Spremite trenutnu snimku zaslona cijele aplikacije.";
            this.spremanjeSnimkeZaslona.Click += new System.EventHandler(this.SpremanjeSnimkeZaslona_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1030, 507);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GPS aplikacija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelDesni.ResumeLayout(false);
            this.tableLayoutPanelDesni.PerformLayout();
            this.tableLayoutPanelStrelice.ResumeLayout(false);
            this.panelSaKontrolama.ResumeLayout(false);
            this.panelSaKontrolama.PerformLayout();
            this.Dodaj.ResumeLayout(false);
            this.Dodaj.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip Dodaj;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem čvorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bridToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem najkraćiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posaoUsputToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label koordinatePokazivaca;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDesni;
        private System.Windows.Forms.Button gumbSmanji;
        private System.Windows.Forms.Button gumbPovecaj;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStrelice;
        private System.Windows.Forms.Button gumbGore;
        private System.Windows.Forms.Button gumbLijevo;
        private System.Windows.Forms.Button gumbDesno;
        private System.Windows.Forms.Button gumbDolje;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.Panel panelSaKontrolama;
        private System.Windows.Forms.ToolStripDropDownButton OdaberiBoje;
        private System.Windows.Forms.ToolStripMenuItem bojaCesteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bojaČvorToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton spremanjeSnimkeZaslona;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem formaPozadinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem odaberiFontToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem sviranje;
        private System.Windows.Forms.Label vrijeme;
        private System.Windows.Forms.Timer timer1;
    }
}