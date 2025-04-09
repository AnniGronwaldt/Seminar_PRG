using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovani
{
    public partial class Form1 : Form
    {
        //Graphics paint = CreateGraphics;

        bool userbrush;
        bool userpen;
        bool userairbrush;

        Color pen;
        Color brush;

        TextureBrush airbrush = new TextureBrush(brush);

        bool userruler;

        SolidBrush ruler = new SolidBrush();

        bool usereraser;
        bool userbucket;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRed(object sender, EventArgs e)
        {
            if (userpen == true)
            {
                Pen pen = Pens.Red;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Red;
            }
            else if (userbucket == true)
            {

            }
            else if (userairbrush == true)
            {
                airbrush = Brushes.Red;
            }

            
            //změní barvu na červenou
            
            
        }

        private void buttonOrange(object sender, EventArgs e)
        {
            //změní barvu na oranžovou
            if (userpen == true)
            {
                Pen pen = Pens.Orange;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Orange;
            }
        }

        private void buttonYellow(object sender, EventArgs e)
        {
            //změní barvu na žlutou
            if (userpen == true)
            {
                Pen pen = Pens.Yellow;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Yellow;
            }
        }

        private void buttonNeonGreen(object sender, EventArgs e)
        {
            //změní barvu na neon zelenou
            if (userpen == true)
            {
                Pen pen = Pens.Green;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Green;
            }
        }

        private void buttonCyan(object sender, EventArgs e)
        {
            //změní barvu na tyrkysovou
            if (userpen == true)
            {
                Pen pen = Pens.Cyan;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Cyan;
            }
        }

        private void buttonBlue(object sender, EventArgs e)
        {
            //změní barvu na modrou
            if (userpen == true)
            {
                Pen pen = Pens.DarkBlue;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.DarkBlue;
            }
        }

        private void buttonPurple(object sender, EventArgs e)
        {
            //změní barvu na fialovou
            if (userpen == true)
            {
                Pen pen = Pens.Purple;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Purple;
            }
        }

        private void colorwheel(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
        }

        private void buttonPink(object sender, EventArgs e)
        {
            //změní barvu na růžovou
            if (userpen == true)
            {
                Pen pen = Pens.Pink;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Pink;
            }
        }

        private void buttonBlack(object sender, EventArgs e)
        {
            //změní barvu na černou
            if (userpen == true)
            {
                Pen pen = Pens.Black;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Black;
            }
        }

        private void buttonGray(object sender, EventArgs e)
        {
            //změní barvu na šedou
            if (userpen == true)
            {
                Pen pen = Pens.Gray;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.Gray;
            }
        }

        private void buttonWhite(object sender, EventArgs e)
        {
            //změní barvu na bílou
            if (userpen == true)
            {
                Pen pen = Pens.White;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.White;
            }
        }

        private void buttonDarkgreen(object sender, EventArgs e)
        {
            //změní barvu na tmavě zelenou
            if (userpen == true)
            {
                Pen pen = Pens.DarkGreen;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.DarkGreen;
            }
        }

        private void buttonBrown(object sender, EventArgs e)
        {
            //změní barvu na hnědou
            if (userpen == true)
            {
                Pen pen = Pens.SaddleBrown;
            }
            else if (userbrush == true)
            {
                Brush brush = Brushes.SaddleBrown;
            }
        }

        private void paint(object sender, MouseEventArgs e)
        {
            
        }

        private void eraser(object sender, EventArgs e)
        {
            eraser(sender, null);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPen(object sender, EventArgs e)
        {
            userpen = true;
        }


        private void buttonBrush(object sender, EventArgs e)
        {
            userbrush = true;
        }

        bool mouseDown;
        bool dragDown;

        private void drawBro(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        Graphics g;

        private void justPleaseDrawIBegYou(object sender, MouseEventArgs e)
        {
            
            dragDown = true;
            Point lastPosition;
            g.DrawCurve;
        }

        private void square(object sender, EventArgs e)
        {
            Graphics g;
            g.DrawRectangle();
        }

        /*
        
        sources:
        /https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fas1.ftcdn.net%2Fv2%2Fjpg%2F02%2F18%2F10%2F04%2F1000_F_218100448_GGMX26wFKhr3if73E5lzgEgPFUeR2VX8.jpg&f=1&nofb=1&ipt=c83c1ead155d7cf9280a752516727b5e8d393aa6ee1cb72b0bc9e6f7e9b66866&ipo=images
        pixabay


        */
    }
}
