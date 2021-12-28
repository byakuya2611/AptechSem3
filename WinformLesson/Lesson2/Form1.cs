using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTriCacl_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1stAngle.Text);
            double b = double.Parse(txt2ndAngle.Text);
            double c = double.Parse(txt3rdAngle.Text);
            double p = a + b + c;
            double p1 = p / 2 ;
            double s1 = p1 * (p1 - a) * (p1 - b) * (p1 - c);
            double s = Math.Sqrt(s1);
            txtTriPeri.Text = p.ToString();
            txtTriArea.Text = s.ToString();
        }

        private void btnRecCacl_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtLength.Text);
            double b = double.Parse(txtWidth.Text);
            double p = (a + b) * 2;
            double s = a * b;
            txtRecPeri.Text = p.ToString();
            txtRecArea.Text = s.ToString();
        }

        
    }
}
