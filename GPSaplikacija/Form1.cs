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
    }
}
