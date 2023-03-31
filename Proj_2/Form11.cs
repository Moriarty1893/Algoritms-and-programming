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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string t1 = "а) Регистры";
            string t2 = "б) Оперативная память";
            string t3 = "в) Магнитная память";
            string t4 = "д) Оптический диск";

            if ((listBox2.Items.Count == 0) || (listBox3.Items.Count == 0) || (listBox4.Items.Count == 0) || (listBox5.Items.Count == 0))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((listBox3.Items[0].ToString() == t4) && (listBox4.Items[0].ToString() == t2) && (listBox2.Items[0].ToString() == t1) && (listBox5.Items[0].ToString() == t3))
            {
                Class1.mas[7] = 1;
            }
            else
            {
                Class1.mas[7] = 0;
            }
            if (!((listBox2.Items.Count == 0) || (listBox3.Items.Count == 0) || (listBox4.Items.Count == 0) || (listBox5.Items.Count == 0)))
            {
                Form12 f = new Form12();
                this.Hide();
                f.ShowDialog();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите термин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(str);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите термин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                listBox3.Items.Add(str);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите термин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                listBox4.Items.Add(str);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите термин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                listBox5.Items.Add(str);
            }
        }
    }
}
