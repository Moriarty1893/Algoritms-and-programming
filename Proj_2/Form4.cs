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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = For_Kyrsovaya.Class1.Vopros1(textBox1.Text);
            if (rez == 1)
            {
                Form5 f = new Form5();
                this.Hide();
                f.ShowDialog();  
            }
        }
    }
}
