using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Курсовая_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public int sec;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            sec++;
            if (sec == 15)
            {
                Form21 f = new Form21();
                f.Show();
                this.Hide();
            }
        }
    }
}
