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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        public int kol;
        public int[] otvet = new int[18];
        public static void Prosmotr(ref int kol, ref DataGridView dgv)
        {
            int[,] mas = new int[1,1];
            mas[0,0] = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            chart1.Series["Правильно"].Points.Clear();
            chart1.Series["Неправильно"].Points.Clear();

            For_Kyrsovaya.Class1.Kol(ref otvet, ref kol);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            
            if (kol <= 8)
            {
                label8.Text = "2";
                label2.Text = "Неудволитворительно";
                player.SoundLocation = @"C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\2.WAV";
            }
            else if (kol <= 11)
            {
                label8.Text = "3";
                label2.Text = "Удволетворительно";
                player.SoundLocation = @"C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\3.WAV";
            }
            else if (kol <= 15)
            {
                label8.Text = "4";
                label2.Text = "Хорошо";
                player.SoundLocation = @"C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\4.WAV";
            }
            else
            {
                label8.Text = "5";
                label2.Text = "Отлично";
                player.SoundLocation = @"C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\5.WAV";
            }

            For_Kyrsovaya.Class1.VivodDGV(ref dataGridView1, otvet);
            player.Play();

            chart1.Series["Правильно"].Points.AddY(kol); //Class1.n  
            chart1.Series["Неправильно"].Points.AddY(18-kol);//18-Class1.n

            int[] new_ = new int[18];
            new_ = otvet;
            For_Kyrsovaya.Class1.Sort(ref new_);
            For_Kyrsovaya.Class1.VivodDGV(ref dataGridView2, new_);
            For_Kyrsovaya.Class1.Zapis_v_bloknot(ref new_);
        }
    }
}
