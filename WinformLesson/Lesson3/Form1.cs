using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1stInteger.Text);
            double b = double.Parse(txt2ndInteger.Text);
            double s = a + b;
            double d = a - b;
            double p = a * b;
            double q = a / b;
            txtSum.Text = s.ToString();
            txtDifference.Text = d.ToString();
            txtProduct.Text = p.ToString();
            txtQuotient.Text = q.ToString();
        }
    }
}
