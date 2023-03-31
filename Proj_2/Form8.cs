using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using For_Kyrsovaya;

namespace _Курсовая_
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros5(radioButton1, radioButton2, radioButton3, radioButton4, radioButton5);
            if (rez == 1)
            {
                Form9 f = new Form9();
                this.Hide();
                f.ShowDialog();
            }
            //4 Microsoft
        }
    }
}
