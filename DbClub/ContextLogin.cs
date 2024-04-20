using DbClub.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbClub
{
    public partial class ContextLogin : Form
    {
        bool flagEye = false;
        public ContextLogin()
        {
            InitializeComponent();
        }



        private void butEye_Click(object sender, EventArgs e)
        {
            flagEye = !flagEye;
            if (flagEye)
            {
                butEye.BackgroundImage = Resources.Visible;
                textBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                butEye.BackgroundImage = Resources.invisible1;
                textBoxPass.UseSystemPasswordChar = true;
            }
        }

        private void butEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Поле пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            DataTable tableCheckPass = new DataTable();
            using (var command = new MySqlCommand("SELECT username, role, users.lock, id, count_attemp, date_lock FROM users WHERE username = @userName;", MainForm.getConnection()))
            {
                command.Parameters.AddWithValue("@userName", textBoxLogin.Text);
                command.Parameters.AddWithValue("@userPass", textBoxPass.Text);
                MainForm.adapter.SelectCommand = command;
                MainForm.adapter.Fill(table);
            }
            if (table.Rows.Count > 0)
            {

                DataRow row = table.Rows[0];

                if ((bool)row["lock"] == true)
                {
                    MessageBox.Show("Пользователь заблокирован. Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (row["date_lock"] != DBNull.Value)
                {
                    DateTime tempTimeDB = (DateTime)row["date_lock"];
                    TimeSpan timeLeft = tempTimeDB.ToLocalTime().AddMinutes(1) - DateTime.Now;

                    if (tempTimeDB.AddMinutes(1) > DateTime.Now)
                    {
                        MessageBox.Show($"Пользователь будет разблокирован через {timeLeft.Seconds} сек", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                        return;
                    }
                    else
                    {
                        using (MySqlCommand command = new MySqlCommand("UPDATE users SET date_lock = @date, count_attemp = @count WHERE username = @userName;", MainForm.getConnection()))
                        {
                            command.Parameters.AddWithValue("@userName", textBoxLogin.Text);
                            command.Parameters.AddWithValue("@date", null);
                            command.Parameters.AddWithValue("@count", 3);
                            command.ExecuteNonQuery();
                        }
                        table = new DataTable();
                        using (var command = new MySqlCommand("SELECT username, role, users.lock, id, count_attemp, date_lock FROM users WHERE username = @userName;", MainForm.getConnection()))
                        {
                            command.Parameters.AddWithValue("@userName", textBoxLogin.Text);
                            command.Parameters.AddWithValue("@userPass", textBoxPass.Text);
                            MainForm.adapter.SelectCommand = command;
                            MainForm.adapter.Fill(table);
                        }
                        row = table.Rows[0];

                    }
                }

                tempId = int.Parse(row["id"].ToString());
                tempCount = int.Parse(row["count_attemp"].ToString());
                MainForm.UserName = row["username"].ToString();
                MainForm.UserRole = row["role"].ToString();

                using (var command = new MySqlCommand("SELECT username FROM users WHERE username = @userName AND password = @userPass;", MainForm.getConnection()))
                {
                    command.Parameters.AddWithValue("@userName", textBoxLogin.Text);
                    command.Parameters.AddWithValue("@userPass", textBoxPass.Text);
                    MainForm.adapter.SelectCommand = command;
                    MainForm.adapter.Fill(tableCheckPass);
                }

                if (tableCheckPass.Rows.Count == 0)
                {
                    if (tempCount == 0)
                    {
                        MainForm.openConnection();
                        using (MySqlCommand command = new MySqlCommand("UPDATE users SET date_lock = @date WHERE id = @idUser;", MainForm.getConnection()))
                        {
                            command.Parameters.AddWithValue("@idUser", tempId);
                            command.Parameters.AddWithValue("@date", DateTime.Now);
                            command.ExecuteNonQuery();
                            MainForm.closeConnection();
                            MessageBox.Show($"Пользователь {textBoxLogin.Text} был заблокирован на 1 минуту. Повторите попытку позже ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    MainForm.openConnection();
                    using (MySqlCommand command = new MySqlCommand("UPDATE users SET count_attemp = count_attemp-1 WHERE id = @idUser;", MainForm.getConnection()))
                    {
                        command.Parameters.AddWithValue("@idUser", tempId);
                        command.ExecuteNonQuery();
                        MainForm.closeConnection();
                        MessageBox.Show($"Неверный пароль! Осталось попыток входа: {tempCount}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                }

                buttonEnter.Text = "Успешно!";
                await Task.Delay(500);
                MainForm form = new MainForm();
                form.Show();
                textBoxLogin.Text = "";
                textBoxPass.Text = "";
                textBoxPass.UseSystemPasswordChar = true;
                buttonEnter.Text = "Вход";
                this.Hide();
            }
            else
            {
                buttonEnter.Text = "Пользователь не найден!";
                await Task.Delay(1000);
                buttonEnter.Text = "Вход";
            }
        }
    }
}
