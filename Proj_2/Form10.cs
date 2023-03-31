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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros7(listBox2, listBox3, listBox4, listBox5);
            if (rez == 1)
            {
                Form11 f = new Form11();
                this.Hide();
                f.ShowDialog();
            }
            //2)а //3)г //1)в //4)б
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
                MessageBox.Show("Выберите термин", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Выберите термин", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                listBox5.Items.Add(str);
            }
        }


    }
}
