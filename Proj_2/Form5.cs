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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string right_ans = "Solaris";
            string ans = textBox1.Text;
            if (ans == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ans == right_ans)
            {
                Class1.mas[1] = 1;
            }
            else
            {
                Class1.mas[1] = 0;
            }
            if (ans != "")
            {
                Form6 f = new Form6();
                this.Hide();
                f.ShowDialog();
            }
            //Solaris 
        }
    }
}
