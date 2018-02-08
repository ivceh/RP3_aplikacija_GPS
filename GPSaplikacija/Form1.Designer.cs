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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.koordinatePokazivaca = new System.Windows.Forms.Label();
            this.tableLayoutPanelDesni = new System.Windows.Forms.TableLayoutPanel();
            this.gumbSmanji = new System.Windows.Forms.Button();
            this.gumbPovecaj = new System.Windows.Forms.Button();
            this.tableLayoutPanelStrelice = new System.Windows.Forms.TableLayoutPanel();
            this.gumbGore = new System.Windows.Forms.Button();
            this.Dodaj = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.čvorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.najkraćiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posaoUsputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.gumbLijevo = new System.Windows.Forms.Button();
            this.gumbDesno = new System.Windows.Forms.Button();
            this.gumbDolje = new System.Windows.Forms.Button();
            this.labelOpis = new System.Windows.Forms.Label();
            this.panelSaKontrolama = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanelDesni.SuspendLayout();
            this.tableLayoutPanelStrelice.SuspendLayout();
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
            this.gumbSmanji.Location = new System.Drawing.Point(15, 3);
            this.gumbSmanji.Name = "gumbSmanji";
            this.gumbSmanji.Size = new System.Drawing.Size(70, 50);
            this.gumbSmanji.TabIndex = 0;
            this.gumbSmanji.UseVisualStyleBackColor = false;
            // 
            // gumbPovecaj
            // 
            this.gumbPovecaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gumbPovecaj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gumbPovecaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gumbPovecaj.BackgroundImage")));
            this.gumbPovecaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gumbPovecaj.Location = new System.Drawing.Point(115, 3);
            this.gumbPovecaj.Name = "gumbPovecaj";
            this.gumbPovecaj.Size = new System.Drawing.Size(70, 50);
            this.gumbPovecaj.TabIndex = 1;
            this.gumbPovecaj.UseVisualStyleBackColor = false;
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
            // 
            // Dodaj
            // 
            this.Dodaj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
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
            this.toolStripButton1.Text = "Dodaj";
            // 
            // čvorToolStripMenuItem
            // 
            this.čvorToolStripMenuItem.Name = "čvorToolStripMenuItem";
            this.čvorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.čvorToolStripMenuItem.Text = "Čvor";
            this.čvorToolStripMenuItem.Click += new System.EventHandler(this.čvorToolStripMenuItem_Click);
            // 
            // bridToolStripMenuItem
            // 
            this.bridToolStripMenuItem.Name = "bridToolStripMenuItem";
            this.bridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bridToolStripMenuItem.Text = "Brid";
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
            this.toolStripButton2.Text = "Nađi put";
            // 
            // najkraćiToolStripMenuItem
            // 
            this.najkraćiToolStripMenuItem.Name = "najkraćiToolStripMenuItem";
            this.najkraćiToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.najkraćiToolStripMenuItem.Text = "Najkraći";
            // 
            // posaoUsputToolStripMenuItem
            // 
            this.posaoUsputToolStripMenuItem.Name = "posaoUsputToolStripMenuItem";
            this.posaoUsputToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.posaoUsputToolStripMenuItem.Text = "Posao usput";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "Pronađi";
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
            this.panelSaKontrolama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSaKontrolama.Location = new System.Drawing.Point(3, 408);
            this.panelSaKontrolama.Name = "panelSaKontrolama";
            this.panelSaKontrolama.Size = new System.Drawing.Size(818, 96);
            this.panelSaKontrolama.TabIndex = 3;
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
            this.Name = "Form1";
            this.Text = "GPS aplikacija";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanelDesni.ResumeLayout(false);
            this.tableLayoutPanelDesni.PerformLayout();
            this.tableLayoutPanelStrelice.ResumeLayout(false);
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
    }
}