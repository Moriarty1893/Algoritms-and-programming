﻿using System;
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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros13(hScrollBar1);
            if (rez == 1)
            {
                Form16 f = new Form16();
                this.Hide();
                f.ShowDialog();
            }
            //1975
        }
 
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }
    }
}
