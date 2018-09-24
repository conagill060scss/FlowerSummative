using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerSummative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            button1.Visible = false;
            int x = 10;
            int y = 190;

            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Brown, 10);
            SolidBrush drawbrush = new SolidBrush(Color.Yellow);

            while (x < 370)
            {
                g.Clear(Color.White);
                g.DrawRectangle(drawPen, x, 190, 5, 5);
                x = x + 15;
                g.DrawRectangle(drawPen, x, 200, 5, 5);
                x = x + 15;
                g.DrawRectangle(drawPen, x, 190, 5, 5);
                x = x + 15;
                Thread.Sleep(500);

            }

            drawPen.Color = Color.Green;
            x = x - 30;
            while (y > 120)
            {
                g.DrawRectangle(drawPen, x, y, 5, 5);
                y = y - 5;
                Thread.Sleep(500);

            }
            g.FillEllipse(drawbrush, x - 10, y - 10, 20, 25);
            Thread.Sleep(500);
            drawbrush.Color = Color.Red;
            g.FillEllipse(drawbrush, x - 10, y - 40, 20, 40);
            Thread.Sleep(500);
            g.TranslateTransform(x + 15, y - 345);
            g.RotateTransform(80);
            g.FillEllipse(drawbrush, x - 8, y - 40, 20, 40);
            g.ResetTransform();
            Thread.Sleep(500);
            g.TranslateTransform(x - 3, y - 365);
            g.RotateTransform(75);
            g.FillEllipse(drawbrush, x + 15, y - 75, 20, 40);
            g.ResetTransform();
            Thread.Sleep(500);
            Graphics z = this.CreateGraphics();
            Font drawFont = new Font("Arial", 36, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            SoundPlayer party_horn = new SoundPlayer(Properties.Resources.party_horn); 
            party_horn.Play();
            z.DrawString("Happy", drawFont, drawBrush, 75, 50);
            z.DrawString("Birthday", drawFont, drawBrush, 400, 50);
        }
    }
    }