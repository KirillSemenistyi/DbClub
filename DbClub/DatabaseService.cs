using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbClub
{
    public class DatabaseService
    {
        public Database database;

        public MySqlDataAdapter adapter;

        public DatabaseService(Database database)
        {
            this.database = database;
            adapter = new MySqlDataAdapter();
        }

        public void openConnection()
        {
            if (database.connection.State == ConnectionState.Closed) database.connection.Open();
        }

        public void closeConnection()
        {
            if (database.connection.State == ConnectionState.Open) database.connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return database.connection;
        }

        public void LoadDataGrid(string cmd, DataTable table, DataGridView dataGrid, int it)
        {
            table.Clear();
            using (MySqlCommand command = new MySqlCommand(cmd, getConnection()))
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            dataGrid.DataSource = table;
            for (int i = 0; i < it; i++) dataGrid.Columns[i].Visible = false;
        }
        public void LoadDataGrid(string cmd, DataTable table, DataGridView dataGrid, int it, string[] values)
        {
            string[] parametrs = FindParametrsInCommand(cmd);
            table.Clear();
            using (MySqlCommand command = new MySqlCommand(cmd, getConnection()))
            {
                for (int i = 0; i < parametrs.Length; i++) command.Parameters.AddWithValue(parametrs[i], values[i]);
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            dataGrid.DataSource = table;
            for (int i = 0; i < it; i++) dataGrid.Columns[i].Visible = false;
        }



        public void LoadComboBox(ref ComboBox comboBox, ref List<int> list, string com, int countCol = 1, int startCol = 1)
        {
            comboBox.Items.Clear();
            list.Clear();
            string item;
            openConnection();
            using (MySqlCommand command = new MySqlCommand(com, getConnection()))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = "";
                        for (int i = startCol; i <= countCol-1; i++) item += reader[i].ToString() + " ";
                        item += reader[countCol].ToString();
                        comboBox.Items.Add(item);
                        list.Add(reader.GetInt32(0));
                    }
                }
            }
            closeConnection();
        }

        public void DeleteRecord(ref DataGridViewRow tempRecord, string commandDelete)
        {
            try
            {
                if (tempRecord == null)
                {
                    MessageBox.Show("Вы не выбрали запись!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                openConnection();
                using (MySqlCommand command = new MySqlCommand(commandDelete, getConnection()))
                {
                    command.Parameters.AddWithValue("@id", tempRecord.Cells[0].Value.ToString());
                    command.ExecuteNonQuery();
                }
                closeConnection();
                tempRecord = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        public void DeleteRecord(string val, string commandDelete)
        {
            try
            {
                openConnection();
                using (MySqlCommand command = new MySqlCommand(commandDelete, getConnection()))
                {
                    command.Parameters.AddWithValue("@id", val);
                    command.ExecuteNonQuery();
                }
                closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
        }

        private string[] FindParametrsInCommand(string com)
        {
            MatchCollection matches = Regex.Matches(com, @"@\w+");
            string[] parametrs = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++) parametrs[i] = matches[i].Value;
            return parametrs;
        }

        public void OperationOnRecord(string com, string[] values)
        {
            string[] parametrs = FindParametrsInCommand(com);
            openConnection();
            using (MySqlCommand command = new MySqlCommand(com, getConnection()))
            {
                for (int i = 0; i < parametrs.Length; i++) command.Parameters.AddWithValue(parametrs[i], values[i]);
                try { command.ExecuteNonQuery(); }
                catch (Exception exp)
                {
                    MessageBox.Show($"При выполнении операции произошла ошибка: {exp.Message}", "Произошла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            closeConnection();
        }

        public DataTable OperationSelect(string com, string[] values)
        {
            DataTable table = new DataTable();
            string[] parametrs = FindParametrsInCommand(com);
            using (var command = new MySqlCommand(com, getConnection()))
            {
                for (int i = 0; i < parametrs.Length; i++) command.Parameters.AddWithValue(parametrs[i], values[i]);
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            return table;
        }
    }
}
