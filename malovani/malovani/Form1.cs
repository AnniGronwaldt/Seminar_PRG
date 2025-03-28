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
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRed(object sender, EventArgs e)
        {
            //změní barvu na červenou
            Pen pen = Pens.Red;
            Brush brush = Brushes.Red;
        }

        private void buttonOrange(object sender, EventArgs e)
        {
            //změní barvu na oranžovou
            Pen pen = Pens.Orange;
            Brush brush = Brushes.Orange;
        }

        private void buttonYellow(object sender, EventArgs e)
        {
            //změní barvu na žlutou
            Pen pen = Pens.Yellow;
            Brush brush = Brushes.Yellow;
        }

        private void buttonNeonGreen(object sender, EventArgs e)
        {
            //změní barvu na neon zelenou
            Pen pen = Pens.Green;
            Brush brush = Brushes.Green;
        }

        private void buttonCyan(object sender, EventArgs e)
        {
            //změní barvu na tyrkysovou
            Pen pen = Pens.Cyan;
            Brush brush = Brushes.Cyan;
        }

        private void buttonBlue(object sender, EventArgs e)
        {
            //změní barvu na modrou
            Pen pen = Pens.DarkBlue;
            Brush brush = Brushes.DarkBlue;
        }

        private void buttonPurple(object sender, EventArgs e)
        {
            //změní barvu na fialovou
            Pen pen = Pens.Purple;
            Brush brush = Brushes.Purple;
        }

        private void colorwheel(object sender, EventArgs e)
        {

        }

        private void buttonPink(object sender, EventArgs e)
        {
            //změní barvu na růžovou
            Pen pen = Pens.Pink;
            Brush brush = Brushes.Pink;
        }

        private void buttonBlack(object sender, EventArgs e)
        {
            //změní barvu na černou
            Pen pen = Pens.Black;
            Brush brush = Brushes.Black;
        }

        private void buttonGray(object sender, EventArgs e)
        {
            //změní barvu na šedou
            Pen pen = Pens.Gray;
            Brush brush = Brushes.Gray;
        }

        private void buttonWhite(object sender, EventArgs e)
        {
            //změní barvu na bílou
            Pen pen = Pens.White;
            Brush brush = Brushes.White;
        }

        private void buttonDarkgreen(object sender, EventArgs e)
        {
            //změní barvu na tmavě zelenou
            Pen pen = Pens.DarkGreen;
            Brush brush = Brushes.DarkGreen;
        }

        private void buttonBrown(object sender, EventArgs e)
        {
            //změní barvu na hnědou
            Pen pen = Pens.SaddleBrown;
            Brush brush = Brushes.SaddleBrown;
        }

        private void paint(object sender, MouseEventArgs e)
        {
            
        }

        private void eraser(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
