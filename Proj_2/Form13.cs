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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros10(comboBox1.SelectedIndex.ToString());
            if (rez == 1)
            {
                Form14 f = new Form14();
                this.Hide();
                f.ShowDialog();
            }
            //RISK
        }
    }
}
