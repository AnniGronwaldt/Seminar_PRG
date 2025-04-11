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


        public Form1()
        {
            InitializeComponent();
        }


        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        { }

        

        //brushes

        public bool userpen;
        public bool userbrush;
        public bool userairbrush;
        public bool userkaligraphy;
        public bool userreversekaligraphy;
        public bool userhighlighter;
        public bool userline;

        private void pen(object sender, EventArgs e)
        {
            userpen = true;
        }

        private void brush(object sender, EventArgs e)
        {
            userbrush = true;
        }

        private void airbrush(object sender, EventArgs e)
        {
            userairbrush = true;
        }







        //colors

        int color;

        private void buttonRed(object sender, EventArgs e)
        {
            color = 1;
            //red
        }

        private void buttonOrange(object sender, EventArgs e)
        {
            color = 2;
            //orange
        }

        private void buttonYellow(object sender, EventArgs e)
        {
            color = 3;
            //yellow
        }

        private void buttonNeonGreen(object sender, EventArgs e)
        {
            color = 4;
            //neongreen
        }

        private void buttonCyan(object sender, EventArgs e)
        {
            color = 5;
            //cyan
        }

        private void buttonBlue(object sender, EventArgs e)
        {
            color = 6;
            //blue
        }

        private void buttonPurple(object sender, EventArgs e)
        {
            color = 7;
            //purple
        }

        private void buttonPink(object sender, EventArgs e)
        {
            color = 8;
            //pink
        }

        private void buttonBlack(object sender, EventArgs e)
        {
            color = 9;
            //black
        }

        private void buttonGray(object sender, EventArgs e)
        {
            color = 10;
            //gray
        }

        private void buttonWhite(object sender, EventArgs e)
        {
            color = 11;
            //white
        }

        private void buttonDarkgreen(object sender, EventArgs e)
        {
            color = 12;
            //dark green
        }

        private void buttonBrown(object sender, EventArgs e)
        {
            color = 13;
            //brown
        }

        private void buttonDarkBlue(object sender, EventArgs e)
        {
            color = 14;
            //darkblue
        }



        private void eraser(object sender, EventArgs e)
        {
            Pen eraser = Pens.White;
        }

        //shapes

        private void square(object sender, EventArgs e)
        {

        }

        private void circle(object sender, EventArgs e)
        {

        }

        private void rectangle(object sender, EventArgs e)
        {

        }







        // mouse

        bool mouseDown;
        bool mouseMove;
        bool mouseUp;

        Graphics g;

        private void drawBro(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            Point lastPosition;
            lastPosition = e.Location;

            if (userpen == true)
            {
                if (color == 1) { g.DrawLine(Pens.Red, e.Location, lastPosition); }
                if (color == 2) { g.DrawLine(Pens.Orange, e.Location, lastPosition); }
                if (color == 3) { g.DrawLine(Pens.Yellow, e.Location, lastPosition); }
                if (color == 4) { g.DrawLine(Pens.Green, e.Location, lastPosition); }
                if (color == 5) { g.DrawLine(Pens.Cyan, e.Location, lastPosition); }
                if (color == 6) { g.DrawLine(Pens.DeepSkyBlue, e.Location, lastPosition); }
                if (color == 7) { g.DrawLine(Pens.Purple, e.Location, lastPosition); }
                if (color == 8) { g.DrawLine(Pens.Pink, e.Location, lastPosition); }
                if (color == 9) { g.DrawLine(Pens.Black, e.Location, lastPosition); }
                if (color == 10) { g.DrawLine(Pens.Gray, e.Location, lastPosition); }
                if (color == 11) { g.DrawLine(Pens.White, e.Location, lastPosition); }
                if (color == 12) { g.DrawLine(Pens.DarkGreen, e.Location, lastPosition); }
                if (color == 13) { g.DrawLine(Pens.SaddleBrown, e.Location, lastPosition); }
                if (color == 14) { g.DrawLine(Pens.DarkBlue, e.Location, lastPosition); }

            }
            else if (userbrush == true)
            {
                if (color == 1) { g.DrawLine(Pens.Red, e.Location, lastPosition); }
                if (color == 2) { g.DrawLine(Pens.Orange, e.Location, lastPosition); }
                if (color == 3) { g.DrawLine(Pens.Yellow, e.Location, lastPosition); }
                if (color == 4) { g.DrawLine(Pens.Green, e.Location, lastPosition); }
                if (color == 5) { g.DrawLine(Pens.Cyan, e.Location, lastPosition); }
                if (color == 6) { g.DrawLine(Pens.DeepSkyBlue, e.Location, lastPosition); }
                if (color == 7) { g.DrawLine(Pens.Purple, e.Location, lastPosition); }
                if (color == 8) { g.DrawLine(Pens.Pink, e.Location, lastPosition); }
                if (color == 9) { g.DrawLine(Pens.Black, e.Location, lastPosition); }
                if (color == 10) { g.DrawLine(Pens.Gray, e.Location, lastPosition); }
                if (color == 11) { g.DrawLine(Pens.White, e.Location, lastPosition); }
                if (color == 12) { g.DrawLine(Pens.DarkGreen, e.Location, lastPosition); }
                if (color == 13) { g.DrawLine(Pens.SaddleBrown, e.Location, lastPosition); }
                if (color == 14) { g.DrawLine(Pens.DarkBlue, e.Location, lastPosition); }

                //NOT PENS, BUT BRUSHES!!
            }
            else if (userairbrush == true)
            {

            }

            
        }

        private void iBegYouPleaseDraw(object sender, MouseEventArgs e)
        {
            mouseMove = true;
        }

        private void stop(object sender, MouseEventArgs e)
        {
            mouseMove = false;
            mouseUp = true;
            mouseDown = false;
        }



        private void width(object sender, EventArgs e)
        {
            int i;
            //width(i, i++)
        }

        
    }
}
