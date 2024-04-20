using DbClub.Properties;
using MySqlConnector;
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
            MainForm.db = new Database(new MySqlConnection("Server=127.0.0.1;Port=3306;User ID=root; Database=dbclub;Allow Zero DateTime=True"));
            MainForm.serviceDb = new DatabaseService(MainForm.db);
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
            if (textBoxLog.Text == "" && textBoxPass.Text == "")
            {
                MessageBox.Show("Поле пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Вспомогательная таблица
            DataTable table;

            //Попытка найти пользователя в таблице
            table = MainForm.serviceDb.OperationSelect("SELECT * FROM user WHERE Login = @login;", [textBoxLog.Text]);


            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];

                if ((bool)row["IsLock"] == true)
                {
                    MessageBox.Show("Пользователь заблокирован. Обратитесь к администратору!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Проверка пароля

                if (textBoxPass.Text != row["Password"].ToString())
                {
                    MessageBox.Show($"Неверный логин/пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainForm form = new MainForm();
                form.Show();
                textBoxLog.Text = "";
                textBoxPass.Text = "";
                this.Hide();
            }
            else
            {
                MessageBox.Show($"Неверный логин/пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ContextLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
