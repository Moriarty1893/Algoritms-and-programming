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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(trackBar1.Value) == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToString(trackBar1.Value) == "9")
            {
                Class1.mas[11] = 1;
            }
            else
            {
                Class1.mas[11] = 0;
            }
            if (!(Convert.ToString(trackBar1.Value) == ""))
            {
                Form22 f = new Form22();
                this.Hide();
                f.ShowDialog();
            }
            //9 1947
        }
    }
}
