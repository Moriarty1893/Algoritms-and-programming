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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1 3 5 6    
            if ((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked) && (!checkBox5.Checked) && (!checkBox6.Checked))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((checkBox1.Checked) && (!checkBox2.Checked) && (checkBox3.Checked) && (!checkBox4.Checked) && (checkBox5.Checked) && (checkBox6.Checked))
            {
                Class1.mas[2] = 1;
            }
            else
            {
                Class1.mas[2] = 0;
            }
            if (!((!checkBox1.Checked) && (!checkBox2.Checked) && (!checkBox3.Checked) && (!checkBox4.Checked) && (!checkBox5.Checked) && (!checkBox6.Checked)))
            {
                Form7 f = new Form7();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
