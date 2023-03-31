using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Курсовая_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @"C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\Sound.WAV";
            player.Play();
            this.Visible = false;

            Form2 f = new Form2();
            f.Show();
        }
    }
}
