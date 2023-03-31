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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //3/Cуперкомпьютеры
            if ((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked) && (!radioButton5.Checked))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((radioButton1.Checked == false) && (radioButton2.Checked == false) && (radioButton4.Checked == false) && (radioButton3.Checked == true) && (radioButton5.Checked == false))
            {
                Class1.mas[5] = 1;
            }
            else
            {
                Class1.mas[5] = 0;
            }
            if (!((!radioButton1.Checked) && (!radioButton2.Checked) && (!radioButton3.Checked) && (!radioButton4.Checked) && (!radioButton5.Checked)))
            {
                Form10 f = new Form10();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
