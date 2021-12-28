using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            String fullname = txtFullname1.Text;
            txtShow.Text = fullname;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit!!!");
            
        }
    }
}
