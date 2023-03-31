using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Kyrsovaya
{
    public class Class2
    {
        public static void BD_1(ref DataGridView dgw)
        {
            string query = "Select * From [Таблица1]";
            string f1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var f = new OleDbConnection(f1);
            f.Open();
            OleDbCommand command = new OleDbCommand(query, f);
            var Reader = command.ExecuteReader();
            var Table = new DataTable();
            Table.Columns.Add(Reader.GetName(0));
            Table.Columns.Add(Reader.GetName(1));
            Table.Columns.Add(Reader.GetName(2));
            while (Reader.Read() == true)
                Table.Rows.Add(Reader.GetValue(0), Reader.GetValue(1), Reader.GetValue(2));
            Reader.Close();
            dgw.DataSource = Table;
        }
        public static void BD_2(ref DataGridView dgw)
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            if (p.State == ConnectionState.Closed)
                p.Open();
            var data = new DataSet();
            var adapter = new OleDbDataAdapter("Select * From Таблица1", p);
            adapter.Fill(data, "Таблица1");
            dgw.DataSource = data;
            dgw.DataMember = "Таблица1";

        }
        public static void Change()
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string LogAp = Interaction.InputBox("Введите логин, котроый хотите измененить", "Заголовок окна", " ", -1, -1);
            string Log = Interaction.InputBox("Новый логин", "Заголовок окна", " ",-1, -1);
            string Par = Interaction.InputBox("Новый пароль", "Заголовок окна", " ",-1, -1);
            string update_query = "UPDATE [Таблица1] SET [Login]=@Log, [Pass]=@Pas WHERE[Login] = @LogAp";
            OleDbCommand command_4 = new OleDbCommand(update_query, p);
            command_4.Parameters.Add("@Log", OleDbType.VarWChar).Value = Log;
            command_4.Parameters.Add("@Par", OleDbType.VarWChar).Value = Par;
            command_4.Parameters.Add("@LogAp", OleDbType.Char).Value = LogAp;
            command_4.ExecuteNonQuery();
            p.Close();
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
        public static void DeleteLog()
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =  C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string Log = Interaction.InputBox("Введите логин для удаления записи из БД", "Заголовок окна", " ", -1, -1);
            string query = "DELETE * FROM Таблица1 WHERE " + "Login Like @Log";
            OleDbCommand command = new OleDbCommand(query, p);
            command.Parameters.Add("@Log", OleDbType.VarWChar).Value = Log;
            var i = command.ExecuteNonQuery();
            if (i > 0)
                MessageBox.Show("Запись удалена", "Заголовок окна",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (i == 0)
                MessageBox.Show("Запись не найдена", "Заголовок окна", MessageBoxButtons.OK, MessageBoxIcon.Error);
            p.Close();
        }
        public static void Vivod_LS(ref ListBox LB)
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string query = "SELECT Login, Pass FROM Таблица1 ORDER BY Login";
            OleDbCommand command = new OleDbCommand(query, p);
            OleDbDataReader reader = command.ExecuteReader();
            LB.Items.Clear();
            while (reader.Read())
            {
                LB.Items.Add(reader[0].ToString() + " " + reader[1].ToString() + "");
            }
            reader.Close();
        }
        public static void ReadTB(ref TextBox TB)
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string query = "SELECT Login, Pass FROM Таблица1 ORDER BY Login";
            OleDbCommand command = new OleDbCommand(query, p);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                TB.Text += reader[0].ToString() + " " + reader[1].ToString() + "; ";
            }
            reader.Close();
            p.Close();
        }

        public static void SortDBinDGV(ref DataGridView DGV)
        {
            string p1 = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\Bulat\Desktop\Мои проекты\Курсовые\АиП\_Курсовая_\bin\Debug\DB11.accdb";
            var p = new OleDbConnection(p1);
            p.Open();
            string Sort = Interaction.InputBox("Выбор из таблицы БД только тех записей, поле Логин которых  содержит определенный(-ые) символ(-ы).", "Заголовок окна", " ", -1, -1);
            var adapter = new OleDbDataAdapter($"SELECT * FROM Таблица1 WHERE (Login LIKE '%{Sort}%')", p);
            var data = new DataSet();
            adapter.Fill(data, "Users");
            DGV.DataSource = data;
            DGV.DataMember = "Users";
            p.Close();
        }



    }
}
