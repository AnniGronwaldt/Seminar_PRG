using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;
            kp.DrawLine(Pens.Blue, 0, 0, 200, 100);
            kp.DrawLine(Pens.Red, 0, 100, 200, 100);
            kp.DrawRectangle(Pens.Green, 200, 100, 50, 100);
            kp.DrawEllipse(Pens.Red, 200, 100, 50, 100);
            kp.FillEllipse(Brushes.Blue, 50, 50, 50, 50);
            kp.FillRectangle(Brushes.Orange, 100, 100, 50, 50);

        }
    }
}
