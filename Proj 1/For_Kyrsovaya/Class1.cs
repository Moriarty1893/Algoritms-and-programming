using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Kyrsovaya
{
    public class Class1
    {
        public static int[] mas = new int[18];
        public static int k = 0;
        public static void Zapis_v_bloknot(ref int[] mas)
        {
            StreamWriter rez = File.CreateText("Lr1_mas.txt");
            rez.WriteLine("Сортированный массив");
            for (int i = 0; i < mas.Length; i++)
            {
                rez.WriteLine(mas[i]);
            }
            rez.WriteLine("");
            rez.Close();
            System.Diagnostics.Process.Start("Lr1_mas.txt");
        }

        public static void SortPassDGV(TextBox tb, TextBox log)
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string Sort = Interaction.InputBox("Выбор из таблицы БД только тех записей, поле Логин которых введен в textbox", "Заголовок окна", " ", -1, -1);
            string query = $"SELECT Pass FROM Таблица1 WHERE (Login = '{Sort}')";
            OleDbCommand command = new OleDbCommand(query, p);
            OleDbDataReader reader = command.ExecuteReader();

            if (reader.FieldCount == 0)
                MessageBox.Show("Ошибка");
            while (reader.Read())
            {
                tb.Text = reader[0].ToString();
            }
            reader.Close();
            p.Close();
            log.Text = Sort.ToString();
        }
        public static void NewLogPass()
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string Log = Interaction.InputBox("Регистрация логина", "Заголовок окна", " ", -1, -1);
            string Par = Interaction.InputBox("Регистрация пароля", "Заголовок окна", " ", -1, -1);
            string query = "INSERT INTO Таблица1 (Login, Pass) VALUES (@Log, @Par)";
            OleDbCommand command = new OleDbCommand(query, p);
            command.Parameters.Add("@Log", OleDbType.VarWChar).Value = Log;
            command.Parameters.Add("@Par", OleDbType.VarWChar).Value = Par;
            command.ExecuteNonQuery();
            p.Close();
        }
        public static void Sort(ref int[] new_)
        {
            int x, left, right, m;
            for (int i = 1; i < new_.Length; i++)
            {
                x = new_[i];
                left = 1;
                right = i - 1;
                while (left <= right)
                {
                    m = (left + right) / 2;
                    if (x < new_[m])
                    {
                        right = m - 1;
                    }
                    else
                    {
                        left = m + 1;
                    }
                }
                for (int j = i - 1;j > left; j=j-1)
                { 
                    new_[j + 1] = new_[j];                       
                }
                new_[left] = x;
            }
        }
        public static void VivodDGV(ref DataGridView dgv, params int[] a)
        {
            dgv.RowCount = 2;
            dgv.ColumnCount = a.GetLength(0);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                dgv.Rows[0].Cells[i].Value = "[" + (i+1) + "]";
                dgv.Rows[1].Cells[i].Value = a[i];
            }
        }
        public static void VivodDGV2(ref DataGridView dgv, params string[] a)
        {
            dgv.RowCount = 2;
            dgv.ColumnCount = a.GetLength(0);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                dgv.Rows[0].Cells[i].Value = "[" + (i + 1) + "]";
                dgv.Rows[1].Cells[i].Value = a[i];
            }
        }
        public static void Kol(ref int[] otvet, ref int kol)
        {
            otvet = mas;
            k = 0;
            for (int i = 0; i < otvet.Length; i++)
            {
                if (otvet[i] == 1)
                {
                    k++;
                }
            }
            kol = k;
        }
        public static void Vivod_mas(ref DataGridView DGV, params String[] a)
        {
            DGV.RowCount = 2;
            DGV.ColumnCount = a.GetLength(0);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                DGV.Rows[0].Cells[i].Value = "[" + (i + 1) + "]";
                DGV.Rows[1].Cells[i].Value = a[i];
            }
        }
        public static int Vopros1(string ans)
        {
            string right_ans = "Мультипрограммирование";
            if (ans == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }
            else if (ans == right_ans)
            {
                mas[0] = 1;
            }
            else
            {
                mas[0] = 0;
            }
            return 1;
        }
        public static int Vopros5(RadioButton RB1, RadioButton RB2, RadioButton RB3, RadioButton RB4, RadioButton RB5)
        {
            if ((!RB1.Checked) && (!RB2.Checked) && (!RB3.Checked) && (!RB4.Checked) && (!RB5.Checked))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((RB1.Checked == false) && (RB2.Checked == false) && (RB3.Checked == false) && (RB4.Checked == true) && (RB5.Checked == false))
            {
                mas[4] = 1;
            }
            else
            {
                mas[4] = 0;
            }
            return 1;
        }
        public static int Vopros7(ListBox LB2, ListBox LB3, ListBox LB4, ListBox LB5)
        {
            string t1 = "а) Группы компьютеров, физически расположенные рядом и соединенные друг с другом ";
            string t2 = "б) Традиционное историческое название для компьютеров, распространенных в 1950-х - 1970-х гг.";
            string t3 = "в) Мощные многопрoцессорные компьютеры, современные имеют производительность до нескольких сотен petaflops";
            string t4 = "г) Это миниатюрные компьютеры, по своим параметрам не уступающие настольным, помещаются в сумку";

            if ((LB2.Items.Count == 0) || (LB3.Items.Count == 0) || (LB4.Items.Count == 0) || (LB5.Items.Count == 0))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if ((LB3.Items[0].ToString() == t1) && (LB4.Items[0].ToString() == t4) && (LB2.Items[0].ToString() == t3) && (LB5.Items[0].ToString() ==t2))
            {
                mas[6] = 1;
            }
            else
            {
                mas[6] = 0;
            }
            return 1;
        }
        public static int Vopros9(string ans)
        {
            if (ans == "-1")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (ans == "2")
            {
                mas[8] = 1;
            }
            else
            {
                mas[8] = 0;
            }
            return 1;
        }
        public static int Vopros10(string ans)
        {
            if (ans == "-1")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (ans == "3")
            {
                mas[9] = 1;
            }
            else
            {
                mas[9] = 0;
            }
            return 1;
        }
        public static int Vopros12(TrackBar TB)
        {
            if (Convert.ToString(TB.Value) == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (Convert.ToString(TB.Value) == "9")
            {
                mas[11] = 1;
            }
            else
            {
                mas[11] = 0;
            }
            return 1;
        }
        public static int Vopros13(HScrollBar HB)
        {
            if (Convert.ToString(HB.Value) == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (Convert.ToString(HB.Value) == "1975")
            {
                mas[12] = 1;
            }
            else
            {
                mas[12] = 0;
            }
            return 1;
        }
        public static int Vopros14(HScrollBar HB)
        {
            if (Convert.ToString(HB.Value) == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (Convert.ToString(HB.Value) == "1015")
            {
                mas[13] = 1;
            }
            else
            {
                mas[13] = 0;
            }
            return 1;
        }
        public static int Vopros15(CheckedListBox CLB)
        {
            if (!CLB.CheckedIndices.Contains(0) && !CLB.CheckedIndices.Contains(1) && !CLB.CheckedIndices.Contains(2) && !CLB.CheckedIndices.Contains(3) && !CLB.CheckedIndices.Contains(4) && !CLB.CheckedIndices.Contains(5))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (CLB.CheckedIndices.Contains(0) && !CLB.CheckedIndices.Contains(1) && CLB.CheckedIndices.Contains(2) && !CLB.CheckedIndices.Contains(3) && CLB.CheckedIndices.Contains(4) && CLB.CheckedIndices.Contains(5))
            {
                mas[14] = 1;
            }
            else
            {
                mas[14] = 0;
            }
            return 1;
        }
        public static int Vopros16(CheckedListBox CLB)
        {
            if (!CLB.CheckedIndices.Contains(0) && !CLB.CheckedIndices.Contains(1) && !CLB.CheckedIndices.Contains(2) && !CLB.CheckedIndices.Contains(3) && !CLB.CheckedIndices.Contains(4) && !CLB.CheckedIndices.Contains(5) && !CLB.CheckedIndices.Contains(6))
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (!CLB.CheckedIndices.Contains(0) && CLB.CheckedIndices.Contains(1) && !CLB.CheckedIndices.Contains(2) && CLB.CheckedIndices.Contains(3) && !CLB.CheckedIndices.Contains(4) && !CLB.CheckedIndices.Contains(5) && CLB.CheckedIndices.Contains(6))
            {
                mas[15] = 1;
            }
            else
            {
                mas[15] = 0;
            }
            return 1;
        }
        public static int Vopros17(DomainUpDown t)
        {
            if (t.Text == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (Convert.ToString(t.SelectedIndex) == "1")
            {
                mas[16] = 1;
            }
            else
            {
                mas[16] = 0;
            }
            return 1;
        }
        public static int Vopros18(DomainUpDown t)
        {
            if (t.Text == "")
            {
                MessageBox.Show("Вы не ответили на вопрос", "Нет ответа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
            else if (Convert.ToString(t.SelectedIndex) == "0")
            {
                mas[17] = 1;
            }
            else
            {
                mas[17] = 0;
            }
            return 1;
        }
    }
}
