using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovani
{
 
    

    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }


        
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }

        

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




        //

        int x;
        private void width(object sender, EventArgs e)
        {
            if (userpen == true)
            {
                Pen.Width = width.Value;
            }
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


        private void sizeSet(object sender, EventArgs e)
        {
             int y = Convert.ToInt32;
        }

        private void square(object sender, EventArgs e)
        {
            if (mouseDown == true)
            {
                mouseDown = true;
                Point lastPosition;
                lastPosition = e.Location;

                g.DrawRectangle(50, 50, e.Location);
            }
            
        }

        private void circle(object sender, EventArgs e)
        {
            if (mouseDown == true)
            {
                mouseDown = true;
                Point lastPosition;
                lastPosition = e.Location;

                g.DrawEllipse(50, 50, e.Location);
            }

        }

        private void rectangle(object sender, EventArgs e)
        {
            if (mouseDown == true)
            {
                mouseDown = true;
                Point lastPosition;
                lastPosition = e.Location;

                g.DrawRectangle(50, 100, e.Location);
            }

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
            else if (userkaligraphy)
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

            
        }

        private void iBegYouPleaseDraw(object sender, MouseEventArgs e)
        {
            mouseMove = true;

            g.DrawLine;
        }

        private void stop(object sender, MouseEventArgs e)
        {
            mouseMove = false;
            mouseUp = true;
            mouseDown = false;
        }



        

        private void reset(object sender, EventArgs e)
        {

        }

        
    }

    public class MyBrush
    {
        private int height;
        private int width;

        public MyBrush(int height, int width)
        {
            height = this.height;
            this.width = width;
        }
    }
}
