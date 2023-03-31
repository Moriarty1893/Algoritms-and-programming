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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1 2 3 5
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked) && (!checkBox5.Checked) && (!checkBox6.Checked))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((checkBox1.Checked) && (checkBox2.Checked) && (checkBox3.Checked) && (!checkBox4.Checked) && (checkBox5.Checked) && (!checkBox6.Checked))
            {
                Class1.mas[3] = 1;
            }
            else
            {
                Class1.mas[3] = 0;
            }
            if (!((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked) && (!checkBox5.Checked) && (!checkBox6.Checked)))
            {
                Form8 f = new Form8();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
