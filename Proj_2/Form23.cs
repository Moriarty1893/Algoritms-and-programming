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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rez = Class1.Vopros18(domainUpDown1);
            if (rez == 1)
            {
                Form20 p = new Form20();
                this.Hide();
                p.ShowDialog();
            }
            //0
        }
    }
}
