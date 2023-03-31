using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Курсовая_
{
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.BD_1(ref dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.BD_2(ref dataGridView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.Change();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.NewLogPass();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.DeleteLog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.Vivod_LS(ref listBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.ReadTB(ref textBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class2.SortDBinDGV(ref dataGridView2);
        }
    }
}
