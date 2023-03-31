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
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();    
            Avtor(this, f, textBox1, textBox2); 
        }
        public static void Avtor(Form A, Form B, TextBox t, TextBox t2)
        {
            string Log = t.Text;
            string Pass = t2.Text;
            string pl = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new System.Data.OleDb.OleDbConnection(pl);
            p.Open();
            var c = new System.Data.OleDb.OleDbCommand("SELECT [Login], [Pass] FROM [Таблица1]", p);
            System.Data.OleDb.OleDbDataReader reader = c.ExecuteReader();
            Boolean f = false;
            while (reader.Read())
            {
                if ((Log == reader[0].ToString()) & (Pass == reader[1].ToString()))
                {
                    f = true;
                    MessageBox.Show("Вы авторизированы!", "Авторизация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    A.Hide();
                    B.Show();
                    break;
                }
            }
            if (f == false)
            {
                MessageBox.Show("Неправильный логин или пароль!", "Авторизация", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class1.NewLogPass();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            For_Kyrsovaya.Class1.SortPassDGV(textBox2, textBox1);
        }
    }
}
