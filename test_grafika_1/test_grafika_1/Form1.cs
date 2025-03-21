using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_grafika_1
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
            kp.FillEllipse(Brushes.Yellow, 60, 35, 50, 50);
            kp.FillEllipse(Brushes.Yellow, 70, 75, 40, 40);
            kp.FillEllipse(Brushes.Yellow, 100, 35, 50, 50);
            kp.FillEllipse(Brushes.Yellow, 100, 75, 40, 40);
            kp.FillEllipse(Brushes.Black, 100, 30, 10, 90);
            for (int i = 0; i < 500; i = i+ 100)
            {
                kp.FillEllipse(Brushes.Yellow, 60 + i, 35, 50, 50);
                kp.FillEllipse(Brushes.Yellow, 70 + i, 75, 40, 40);
                kp.FillEllipse(Brushes.Yellow, 100 + i, 35, 50, 50);
                kp.FillEllipse(Brushes.Yellow, 100 + i, 75, 40, 40);
                kp.FillEllipse(Brushes.Black, 100 + i, 30, 10, 90);
            }
        }
    }
}
