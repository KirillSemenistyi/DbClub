using Microsoft.VisualBasic;
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
    public partial class MainForm : Form
    {
        bool flagWait = false;
        public static Database db;
        public static DatabaseService dbService;

        string
            cmdComp = "SELECT `id`, `computer_name` as 'Название компьютера', `specifications` as 'Конфигурация' , `status` as 'Статус'  FROM `computers`",
            cmdVisitors = "SELECT `id`, `first_name` as 'Имя', `surname` as 'Фамилия', `last_name` as 'Отчество', `email` as 'Эл Адрес', `phone` as 'Телефон', DATE_FORMAT(`registration_date`, '%d.%m.%y') as 'Дата регистрации' FROM `visitors`",
            cmdService = "SELECT `id`, `service_name` as 'Название', `price` as 'Цена' FROM `services`",
            cmdVisit = "SELECT visits.`id`, CONCAT(visitors.surname, ' ', visitors.first_name, ' ', CASE WHEN visitors.last_name IS NOT NULL THEN visitors.last_name END) as 'Клиент', computers.computer_name as 'Компьютер',  DATE_FORMAT(`start_time`, '%d.%m.%y %H:%i') as 'Время начала', DATE_FORMAT(`end_time`, '%d.%m.%y %H:%i') as 'Время окончания' FROM visits\r\nLEFT JOIN visitors ON visitors.id = `visitor_id`\r\nLEFT JOIN computers ON computers.id = `computer_id`",
            cmdOrder = "SELECT service_orders.`id`, services.service_name as 'Услуга', `count` as 'Количество' FROM `service_orders` \r\nLEFT JOIN services ON services.id = service_orders.service_id\r\nWHERE `visit_id` = @id";

        DataTable
            tableComp = new DataTable(),
            tableVisitors = new DataTable(),
            tableService = new DataTable(),
            tableVisit = new DataTable(),
            tableOrder = new DataTable();

        public MainForm()
        {
            InitializeComponent();
            dbService.LoadDataGrid(cmdComp, tableComp, dataGridViewComp, 1);
            dbService.LoadDataGrid(cmdVisitors, tableVisitors, dataGridViewVisitors, 1);
            dbService.LoadDataGrid(cmdService, tableService, dataGridViewService, 1);
            dbService.LoadDataGrid(cmdVisit, tableVisit, dataGridViewVisit, 1);
        }

        #region Visit

        private void dataGridViewVisit_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewVisit.SelectedRows.Count != 0 && !flagWait) dbService.LoadDataGrid(cmdOrder, tableOrder, dataGridViewOrder, 1, [dataGridViewVisit.SelectedRows[0].Cells[0].Value.ToString()],ref flagWait);
        }

        void addEditVisit(bool flag)
        {
            List<int>
                idVisitors = new List<int>(),
                idComp = new List<int>();
            ContextVisit contextVisit = new ContextVisit();
            dbService.LoadComboBox(ref contextVisit.comboBoxVisitors, ref idVisitors, "select * from visitors", 3);
            dbService.LoadComboBox(ref contextVisit.comboBoxComp, ref idComp, "select * from computers");
            string[] param = new string[5];
            if (flag)
            {
                contextVisit.Text = "Изменение посещения";
                contextVisit.comboBoxVisitors.SelectedItem = dataGridViewVisit.SelectedRows[0].Cells[1].Value.ToString();
                contextVisit.comboBoxComp.SelectedItem = dataGridViewVisit.SelectedRows[0].Cells[2].Value.ToString();
                contextVisit.dateTimePickerStart.Value = DateTime.Parse(dataGridViewVisit.SelectedRows[0].Cells[3].Value.ToString());
                if (dataGridViewVisit.SelectedRows[0].Cells[4].Value.ToString() != "")
                {
                    contextVisit.dateTimePickerEnd.Value = DateTime.Parse(dataGridViewVisit.SelectedRows[0].Cells[4].Value.ToString());
                    contextVisit.checkBoxEnd.Checked = true;
                }
                param[4] = dataGridViewVisit.SelectedRows[0].Cells[0].Value.ToString();
            }
            if (contextVisit.ShowDialog() == DialogResult.OK)
            {
                param[0] = idVisitors[contextVisit.comboBoxVisitors.SelectedIndex].ToString();
                param[1] = idComp[contextVisit.comboBoxComp.SelectedIndex].ToString();
                param[2] = contextVisit.dateTimePickerStart.Value.ToString("yyyy-MM-dd HH:mm");
                param[3] = contextVisit.checkBoxEnd.Checked ? contextVisit.dateTimePickerEnd.Value.ToString("yyyy-MM-dd HH:mm") : null;
                dbService.OperationOnRecord(flag ? "UPDATE visits SET visitor_id = @_idVis, computer_id = @_idComp, start_time = @start, end_time = @end WHERE id = @_id;" : "INSERT INTO visits VALUES (NULL,@_idVis,@_idComp,@start,@end);", param);
                if (!flagWait) dbService.LoadDataGrid(cmdVisit, tableVisit, dataGridViewVisit, 1,ref flagWait);
            }
        }

        private void butAddVisit_Click(object sender, EventArgs e) => addEditVisit(false);
        private void butEditVisit_Click(object sender, EventArgs e) => addEditVisit(true);

        private void butDeleteVisit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbService.DeleteRecord(dataGridViewVisit.SelectedRows[0].Cells[0].Value.ToString(), "DELETE FROM visits WHERE id = @id");
                if (!flagWait) dbService.LoadDataGrid(cmdVisit, tableVisit, dataGridViewVisit, 1,ref flagWait);
            }
        }


        #endregion

        //Other

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => new ContextLogin().Show();
        private void butCatalog_Click(object sender, EventArgs e) => tabControlMain.SelectedIndex = int.Parse(((Button)sender).Tag.ToString());

        private void butMenu_Click(object sender, EventArgs e) => tabControlMain.SelectedIndex = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());

        
    }
}
