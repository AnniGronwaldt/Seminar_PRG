using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace malovani
{
 
    

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            graffiti.Interval = 40;
            graffiti.Tick += ActualAirbrush;
        }


        Point sprayPoint;
        Random rnd = new Random();
        Timer graffiti = new Timer();

        bool apparentlyAirbrushIsBitchyAndNeedsItsOwnBool = false;

        private void ActualAirbrush (object sender, EventArgs e)
        {
            if (apparentlyAirbrushIsBitchyAndNeedsItsOwnBool == true) return;

            int radius = 40 * y;
            int density = 30;
            using (Graphics g = panel1.CreateGraphics())
            {
                

                for (int i = 0; i < density; i++)
                {

                    double angle = rnd.NextDouble() * Math.PI * 2;
                    double circl = rnd.NextDouble() * radius;
                    int x = (int)(sprayPoint.X + circl * Math.Cos(angle));
                    int y = (int)(sprayPoint.Y + circl * Math.Sin(angle));


                }


                
            }
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
        public bool usereraser;

        private void pen(object sender, EventArgs e)
        {
            BrushReset();
            userpen = true;

        }

        private void brush(object sender, EventArgs e)
        {
            BrushReset();
            userbrush = true;
        }

        private void airbrush(object sender, EventArgs e)
        {
            BrushReset();
            userairbrush = true;
        }

        private void kaligraphy(object sender, EventArgs e)
        {
            BrushReset();
            userkaligraphy = true;
        }

        private void reversekaligraphy(object sender, EventArgs e)
        {
            BrushReset();
            userreversekaligraphy = true;
        }

        private void highlighter(object sender, EventArgs e)
        {
            BrushReset();
            userhighlighter = true;
        }

        private void line(object sender, EventArgs e)
        {
            BrushReset();
            userline = true;
        }



        //

        int x = 1;
        public void width(object sender, EventArgs e)
        {
            trackBar1.Value = x;
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



        bool mouseDown;
        bool mouseMove;
        bool mouseUp;

        public Graphics g;

        private void eraser(object sender, EventArgs e)
        {
            BrushReset();
            usereraser = true;

        }

        //shapes

        int y = 20;
        private void weAreChecking(object sender, EventArgs e)
        {

        }

        private void sizeSet(object sender, EventArgs e)
        {

        }

        private void square(object sender, EventArgs e)
        {
            
        }

        private void squarePlace(object sender, MouseEventArgs e)
        {

            if (mouseDown == true)
            {
                BrushReset();

                int width = 1 * y;
                int height = 1 * y;

                using (Graphics g = panel1.CreateGraphics())
                {
                    if (color == 1) { g.DrawRectangle(Pens.Red, e.X, e.Y, width, height); }
                    if (color == 2) { g.DrawRectangle(Pens.Orange, e.X, e.Y, width, height); }
                    if (color == 3) { g.DrawRectangle(Pens.Yellow, e.X, e.Y, width, height); }
                    if (color == 4) { g.DrawRectangle(Pens.LawnGreen, e.X, e.Y, width, height); }
                    if (color == 5) { g.DrawRectangle(Pens.Cyan, e.X, e.Y, width, height); }
                    if (color == 6) { g.DrawRectangle(Pens.DeepSkyBlue, e.X, e.Y, width, height); }
                    if (color == 7) { g.DrawRectangle(Pens.Purple, e.X, e.Y, width, height); }
                    if (color == 8) { g.DrawRectangle(Pens.Pink, e.X, e.Y, width, height); }
                    if (color == 9) { g.DrawRectangle(Pens.Black, e.X, e.Y, width, height); }
                    if (color == 10) { g.DrawRectangle(Pens.Gray, e.X, e.Y, width, height); }
                    if (color == 11) { g.DrawRectangle(Pens.White, e.X, e.Y, width, height); }
                    if (color == 12) { g.DrawRectangle(Pens.DarkGreen, e.X, e.Y, width, height); }
                    if (color == 13) { g.DrawRectangle(Pens.SaddleBrown, e.X, e.Y, width, height); }
                    if (color == 14) { g.DrawRectangle(Pens.DarkBlue, e.X, e.Y, width, height); }

                }
            }
        }

        private void circle(object sender, EventArgs e)
        {
            
        }

        private void circlePlace(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                BrushReset();

                int width = 1 * y;
                int height = 1 * y;

                using (Graphics g = panel1.CreateGraphics())
                {
                    if (color == 1) { g.DrawEllipse(Pens.Red, e.X, e.Y, width, height); }
                    if (color == 2) { g.DrawEllipse(Pens.Orange, e.X, e.Y, width, height); }
                    if (color == 3) { g.DrawEllipse(Pens.Yellow, e.X, e.Y, width, height); }
                    if (color == 4) { g.DrawEllipse(Pens.LawnGreen, e.X, e.Y, width, height); }
                    if (color == 5) { g.DrawEllipse(Pens.Cyan, e.X, e.Y, width, height); }
                    if (color == 6) { g.DrawEllipse(Pens.DeepSkyBlue, e.X, e.Y, width, height); }
                    if (color == 7) { g.DrawEllipse(Pens.Purple, e.X, e.Y, width, height); }
                    if (color == 8) { g.DrawEllipse(Pens.Pink, e.X, e.Y, width, height); }
                    if (color == 9) { g.DrawEllipse(Pens.Black, e.X, e.Y, width, height); }
                    if (color == 10) { g.DrawEllipse(Pens.Gray, e.X, e.Y, width, height); }
                    if (color == 11) { g.DrawEllipse(Pens.White, e.X, e.Y, width, height); }
                    if (color == 12) { g.DrawEllipse(Pens.DarkGreen, e.X, e.Y, width, height); }
                    if (color == 13) { g.DrawEllipse(Pens.SaddleBrown, e.X, e.Y, width, height); }
                    if (color == 14) { g.DrawEllipse(Pens.DarkBlue, e.X, e.Y, width, height); }

                }

            }

        }

        private void rectangle(object sender, EventArgs e)
        {

        }
        private void rectanglePlace(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                BrushReset();
                
                int width = 1 * y;
                int height = 2 * y;

                using (Graphics g = panel1.CreateGraphics())
                {
                    if (color == 1) { g.DrawRectangle(Pens.Red, e.X, e.Y, width, height); }
                    if (color == 2) { g.DrawRectangle(Pens.Orange, e.X, e.Y, width, height); }
                    if (color == 3) { g.DrawRectangle(Pens.Yellow, e.X, e.Y, width, height); }
                    if (color == 4) { g.DrawRectangle(Pens.LawnGreen, e.X, e.Y, width, height); }
                    if (color == 5) { g.DrawRectangle(Pens.Cyan, e.X, e.Y, width, height); }
                    if (color == 6) { g.DrawRectangle(Pens.DeepSkyBlue, e.X, e.Y, width, height); }
                    if (color == 7) { g.DrawRectangle(Pens.Purple, e.X, e.Y, width, height); }
                    if (color == 8) { g.DrawRectangle(Pens.Pink, e.X, e.Y, width, height); }
                    if (color == 9) { g.DrawRectangle(Pens.Black, e.X, e.Y, width, height); }
                    if (color == 10) { g.DrawRectangle(Pens.Gray, e.X, e.Y, width, height); }
                    if (color == 11) { g.DrawRectangle(Pens.White, e.X, e.Y, width, height); }
                    if (color == 12) { g.DrawRectangle(Pens.DarkGreen, e.X, e.Y, width, height); }
                    if (color == 13) { g.DrawRectangle(Pens.SaddleBrown, e.X, e.Y, width, height); }
                    if (color == 14) { g.DrawRectangle(Pens.DarkBlue, e.X, e.Y, width, height); }

                }
            }
            
        }

        private void ellipse(object sender, EventArgs e)
        {

        }

        private void drawEllipse(object sender, MouseEventArgs e)
        {
            bool ellipseeplacing = true;

            Point lastPosition = this.Location;
            lastPosition.X = e.Location.X;
            lastPosition.Y = e.Location.Y;

            g.DrawEllipse(Pens.Black, e.Location.X, e.Location.Y, 50, 100);
        }


        // mouse

        private void BrushReset()
        {
            userpen = userbrush = userairbrush = userkaligraphy =
            userreversekaligraphy = userhighlighter = userline = false;
        }

        Point lastPosition;
        bool amIDrawingRN = false;

        private void drawBro(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            amIDrawingRN = true;
            lastPosition = e.Location;
        }

        private void iBegYouPleaseDraw(object sender, MouseEventArgs e)
        {
            mouseMove = true;

            if (amIDrawingRN == true)
            {
                if (mouseDown == true)
                {
                    using (Graphics g = panel1.CreateGraphics())
                    {
                        if (userpen == true)
                        {
                            userbrush = userairbrush = userkaligraphy = userreversekaligraphy = userhighlighter = userline = false;
                            Pen pen = new Pen(Color.Black, x);

                            if (color == 1) { g.DrawLine(Pens.Red, e.Location, lastPosition); }
                            if (color == 2) { g.DrawLine(Pens.Orange, e.Location, lastPosition); }
                            if (color == 3) { g.DrawLine(Pens.Yellow, e.Location, lastPosition); }
                            if (color == 4) { g.DrawLine(Pens.LawnGreen, e.Location, lastPosition); }
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
                            lastPosition = e.Location;

                        }
                        else if (userbrush == true)
                        {
                            userpen = userairbrush = userkaligraphy = userreversekaligraphy = userhighlighter = userline = false;

                            if (color == 1) { g.DrawLine(Pens.Red, e.Location, lastPosition); }
                            if (color == 2) { g.DrawLine(Pens.Orange, e.Location, lastPosition); }
                            if (color == 3) { g.DrawLine(Pens.Yellow, e.Location, lastPosition); }
                            if (color == 4) { g.DrawLine(Pens.LawnGreen, e.Location, lastPosition); }
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
                            lastPosition = e.Location;

                            //NOT PENS, BUT BRUSHES!!
                        }
                        else if (userairbrush == true)
                        {
                            userpen = userbrush = userkaligraphy = userreversekaligraphy = userhighlighter = userline = false;

                            sprayPoint = e.Location;
                            graffiti.Start();


                            apparentlyAirbrushIsBitchyAndNeedsItsOwnBool = true;

                            if (color == 1) { g.DrawLine(Pens.Red, e.Location, lastPosition); }
                            if (color == 2) { g.DrawLine(Pens.Orange, e.Location, lastPosition); }
                            if (color == 3) { g.DrawLine(Pens.Yellow, e.Location, lastPosition); }
                            if (color == 4) { g.DrawLine(Pens.LawnGreen, e.Location, lastPosition); }
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
                            lastPosition = e.Location;
                        }
                        else if (userkaligraphy == true)
                        {
                            userpen = userbrush = userairbrush = userreversekaligraphy = userhighlighter = userline = false;

                            if (color == 1)
                            {
                                Brush brush = new SolidBrush(Color.Red);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y , 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 2)
                            {
                                Brush brush = new SolidBrush(Color.Orange);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 3)
                            {
                                Brush brush = new SolidBrush(Color.Yellow);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 4)
                            {
                                Brush brush = new SolidBrush(Color.LawnGreen);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 5)
                            {
                                Brush brush = new SolidBrush(Color.Cyan);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 6)
                            {
                                Brush brush = new SolidBrush(Color.DeepSkyBlue);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 7)
                            {
                                Brush brush = new SolidBrush(Color.Purple);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 8)
                            {
                                Brush brush = new SolidBrush(Color.Pink);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 9)
                            {
                                Brush brush = new SolidBrush(Color.Black);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 10)
                            {
                                Brush brush = new SolidBrush(Color.Gray);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 11)
                            {
                                Brush brush = new SolidBrush(Color.White);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 12)
                            {
                                Brush brush = new SolidBrush(Color.DarkGreen);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 13)
                            {
                                Brush brush = new SolidBrush(Color.SaddleBrown);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            else if (color == 14)
                            {
                                Brush brush = new SolidBrush(Color.DarkBlue);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 10 * x, 2 * x);

                                g.ResetTransform();
                            }
                            lastPosition = e.Location;
                        }
                        else if (userreversekaligraphy == true)
                        {
                            userpen = userbrush = userairbrush = userreversekaligraphy = userhighlighter = userline = false;

                            if (color == 1)
                            {
                                Brush brush = new SolidBrush(Color.Red);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 2)
                            {
                                Brush brush = new SolidBrush(Color.Orange);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 3)
                            {
                                Brush brush = new SolidBrush(Color.Yellow);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 4)
                            {
                                Brush brush = new SolidBrush(Color.LawnGreen);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 5)
                            {
                                Brush brush = new SolidBrush(Color.Cyan);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 6)
                            {
                                Brush brush = new SolidBrush(Color.DeepSkyBlue);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 7)
                            {
                                Brush brush = new SolidBrush(Color.Purple);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 8)
                            {
                                Brush brush = new SolidBrush(Color.Pink);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 9)
                            {
                                Brush brush = new SolidBrush(Color.Black);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 10)
                            {
                                Brush brush = new SolidBrush(Color.Gray);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 11)
                            {
                                Brush brush = new SolidBrush(Color.White);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 12)
                            {
                                Brush brush = new SolidBrush(Color.DarkGreen);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 13)
                            {
                                Brush brush = new SolidBrush(Color.SaddleBrown);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            else if (color == 14)
                            {
                                Brush brush = new SolidBrush(Color.DarkBlue);
                                Matrix transform = new Matrix();
                                transform.RotateAt(45, e.Location);
                                g.Transform = transform;

                                g.FillEllipse(brush, e.Location.X, e.Location.Y, 2 * x, 10 * x);

                                g.ResetTransform();
                            }
                            lastPosition = e.Location;
                        }
                        else if (userhighlighter == true)
                        {
                            userpen = userbrush = userairbrush = userkaligraphy = userreversekaligraphy = userline = false;

                            if (color == 1)
                            {
                                Pen highlighter = new Pen(Color.Red, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Red);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 2)
                            {
                                Pen highlighter = new Pen(Color.Orange, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Orange);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 3)
                            {
                                Pen highlighter = new Pen(Color.Yellow, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Yellow);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 4)
                            {
                                Pen highlighter = new Pen(Color.LawnGreen, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.LawnGreen);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 5)
                            {
                                Pen highlighter = new Pen(Color.Cyan, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Cyan);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 6)
                            {
                                Pen highlighter = new Pen(Color.DeepSkyBlue, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.DeepSkyBlue);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 7)
                            {
                                Pen highlighter = new Pen(Color.Purple, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Purple);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 8)
                            {
                                Pen highlighter = new Pen(Color.Pink, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Pink);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 9)
                            {
                                Pen highlighter = new Pen(Color.Black, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Black);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 10)
                            {
                                Pen highlighter = new Pen(Color.Gray, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.Gray);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 11)
                            {
                                Pen highlighter = new Pen(Color.White, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.White);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 12)
                            {
                                Pen highlighter = new Pen(Color.DarkGreen, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.DarkGreen);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 13)
                            {
                                Pen highlighter = new Pen(Color.SaddleBrown, x * 5);
                                highlighter.Color = Color.FromArgb(128, Color.SaddleBrown);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            else if (color == 14)
                            {
                                Pen highlighter = new Pen(Color.DarkBlue, x);
                                highlighter.Color = Color.FromArgb(128, Color.DarkBlue);
                                g.DrawLine(highlighter, e.Location, lastPosition);
                            }
                            lastPosition = e.Location;
                        }
                        else if (userline == true)
                        {
                            userpen = userbrush = userairbrush = userkaligraphy = userreversekaligraphy = userhighlighter = false;
                            Point old;

                            if (color == 1) { g.DrawLine(Pens.Red, e.Location, lastPosition); }
                            if (color == 2) { g.DrawLine(Pens.Orange, e.Location, lastPosition); }
                            if (color == 3) { g.DrawLine(Pens.Yellow, e.Location, lastPosition); }
                            if (color == 4) { g.DrawLine(Pens.LawnGreen, e.Location, lastPosition); }
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
                            lastPosition = e.Location;
                        }
                        else if (usereraser == true)
                        {
                            g.DrawLine(Pens.White, e.Location, lastPosition);
                        }
                    }
                
                }
            }

        }

        private void stop(object sender, MouseEventArgs e)
        {
            mouseMove = false;
            mouseUp = true;
            mouseDown = false;
            amIDrawingRN = false;
        }



        

        private void reset(object sender, EventArgs e)
        {
            Refresh();
        }

        private void close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save(object sender, EventArgs e)
        {
            var saving = new SaveFileDialog();
            saving.Filter = "Image (*.jpg)|*.jpeg|(*.*|*.*";
            
        }
    }


    // sources: https://www.youtube.com/watch?v=m7Ohm52TIhw
    // chatGPT
    // https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-use-a-pen-to-draw-lines?view=netframeworkdesktop-4.8

}
