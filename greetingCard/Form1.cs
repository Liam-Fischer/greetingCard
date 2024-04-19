using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace greetingCard
    ///Liam Fischer
    ///April 19th, 2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Gold);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen goldPen = new Pen(Color.Goldenrod, 10);
            

            g.Clear(Color.Green);
            g.FillRectangle(redBrush, 0, 50, 750, 360);
            g.FillRectangle(yellowBrush, 0, 100, 750, 260);
            g.FillRectangle(blackBrush, 0, 150, 750, 150);

            g.DrawLine(goldPen, 410, 320, 410, 200);
            g.TranslateTransform(410, 237);
            g.RotateTransform(180);
            g.DrawArc(goldPen, 0, 0, 90, 80, 0, 185);
            g.ResetTransform();
            g.DrawLine(goldPen, 320, 320, 320, 193);
            g.DrawLine(goldPen, 290, 225, 350, 190);
            g.DrawLine(goldPen, 285, 225, 350, 230);
            g.DrawLine(goldPen, 410, 315, 320, 315);


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush blackBrush = new SolidBrush(Color.Black);
            SolidBrush yellowBrush = new SolidBrush(Color.Gold);
            SolidBrush redBrush = new SolidBrush(Color.Red);
            SolidBrush writingBrush = new SolidBrush(Color.PapayaWhip);
            Pen goldPen = new Pen(Color.Goldenrod, 10);
            Font font = new Font ("Ariel Rounded MT", 22, FontStyle.Regular);

            g.Clear(Color.Green);
            g.FillRectangle(redBrush, 0, 50, 750, 360);
            g.FillRectangle(yellowBrush, 0, 100, 750, 260);
            g.FillRectangle(blackBrush, 0, 150, 750, 150);

            for (int i = 0; i <= 200; i++)
            {
                g.Clear(Color.Green);
                g.FillRectangle(redBrush, 0, 50, 750, 360);
                g.FillRectangle(yellowBrush, 0, 100, 750, 260);
                g.FillRectangle(blackBrush, 0, 150, 750, 150);
                g.DrawString("Happy Zimbabwean Indipendence Day!", font, writingBrush, 120, 0 + i);
                Thread.Sleep(10);
            }
            SoundPlayer cheer = new SoundPlayer(Properties.Resources._5_Sec_Crowd_Cheer_Mike_Koenig_1562033255);
            cheer.Play();
            ///The real day of Zimbabwean Indipendence is April 18th
        }
    }
}
