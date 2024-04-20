﻿using Microsoft.VisualBasic;
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
            if (dataGridViewVisit.SelectedRows.Count != 0 && !flagWait) dbService.LoadDataGrid(cmdOrder, tableOrder, dataGridViewOrder, 1, [dataGridViewVisit.SelectedRows[0].Cells[0].Value.ToString()], ref flagWait);
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
                if (!flagWait) dbService.LoadDataGrid(cmdVisit, tableVisit, dataGridViewVisit, 1, ref flagWait);
            }
        }

        private void butAddVisit_Click(object sender, EventArgs e) => addEditVisit(false);
        private void butEditVisit_Click(object sender, EventArgs e) => addEditVisit(true);

        private void butDeleteVisit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbService.DeleteRecord(dataGridViewVisit.SelectedRows[0].Cells[0].Value.ToString(), "DELETE FROM visits WHERE id = @id");
                if (!flagWait) dbService.LoadDataGrid(cmdVisit, tableVisit, dataGridViewVisit, 1, ref flagWait);
            }
        }


        #endregion

        #region Computers

        private void addEditComputers(bool flag)
        {
            ContextComputers contextComputers = new ContextComputers();
            string[] param = new string[4];
            if (flag)
            {
                contextComputers.Text = "Изменение компьютера";
                contextComputers.textBoxCompName.Text = dataGridViewComp.SelectedRows[0].Cells[1].Value.ToString();
                contextComputers.textBoxSpecifications.Text = dataGridViewComp.SelectedRows[0].Cells[2].Value.ToString();
                contextComputers.comboBoxStatus.SelectedItem = dataGridViewComp.SelectedRows[0].Cells[3].Value.ToString();
                param[3] = dataGridViewComp.SelectedRows[0].Cells[0].Value.ToString();
            }
            if (contextComputers.ShowDialog() == DialogResult.OK)
            {
                param[0] = contextComputers.textBoxCompName.Text;
                param[1] = contextComputers.textBoxSpecifications.Text;
                param[2] = contextComputers.comboBoxStatus.SelectedItem.ToString();
                dbService.OperationOnRecord(flag ? "UPDATE computers SET computer_name = @nameComp, specifications = @specComp, status = @statusComp WHERE id = @idComp" : "INSERT INTO `computers`(`id`, `computer_name`, `specifications`, `status`) VALUES (NULL,@nameComp,@specComp,@statusComp)", param);
                if (!flagWait) dbService.LoadDataGrid(cmdComp, tableComp, dataGridViewComp, 1, ref flagWait);
            }
        }

        private void butAddCar_Click(object sender, EventArgs e) => addEditComputers(false);

        private void butEditCar_Click(object sender, EventArgs e) => addEditComputers(true);

        private void butDeleteCar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbService.DeleteRecord(dataGridViewComp.SelectedRows[0].Cells[0].Value.ToString(), "DELETE FROM computers WHERE id = @id");
                if (!flagWait) dbService.LoadDataGrid(cmdComp, tableComp, dataGridViewComp, 1, ref flagWait);
            }
        }

        #endregion

        //Other

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => new ContextLogin().Show();
        private void butCatalog_Click(object sender, EventArgs e) => tabControlMain.SelectedIndex = int.Parse(((Button)sender).Tag.ToString());

        private void butMenu_Click(object sender, EventArgs e) => tabControlMain.SelectedIndex = int.Parse(((ToolStripMenuItem)sender).Tag.ToString());

        #region Visitors

        private void addEditVisitors(bool flag)
        {
            ContextVisitors contextVisitors = new ContextVisitors();
            string[] param = new string[7];
            if (flag)
            {
                contextVisitors.Text = "Изменение посетителя";
                contextVisitors.textBoxSurname.Text = dataGridViewVisitors.SelectedRows[0].Cells[2].Value.ToString();
                contextVisitors.textBoxName.Text = dataGridViewVisitors.SelectedRows[0].Cells[1].Value.ToString();
                contextVisitors.textBoxLastname.Text = dataGridViewVisitors.SelectedRows[0].Cells[3].Value.ToString();
                contextVisitors.textBoxEmail.Text = dataGridViewVisitors.SelectedRows[0].Cells[4].Value.ToString();
                contextVisitors.maskedTextBoxPhoneNumber.Text = dataGridViewVisitors.SelectedRows[0].Cells[5].Value.ToString();
                param[6] = dataGridViewVisitors.SelectedRows[0].Cells[0].Value.ToString();
            }
            if (contextVisitors.ShowDialog() == DialogResult.OK)
            {
                param[0] = contextVisitors.textBoxSurname.Text;
                param[1] = contextVisitors.textBoxName.Text;
                param[2] = contextVisitors.textBoxLastname.Text;
                param[3] = contextVisitors.textBoxEmail.Text;
                param[4] = contextVisitors.maskedTextBoxPhoneNumber.Text;
                param[5] = DateTime.Now.ToString("yyyy-MM-dd");
                dbService.OperationOnRecord(flag ? "UPDATE visitors SET surname = @surname, first_name = @name, last_name = @patronymic, email = @emailAddress, phone = @phoneNumber, registration_date = @date WHERE id = @idVisitor" : "INSERT INTO `visitors`(`id`, `surname`, `first_name`, `last_name`, `email`, `phone`, `registration_date`) VALUES (NULL,@surname,@name,@patronymic,@emailAddress,@phoneNumber,@date)", param);
                if (!flagWait) dbService.LoadDataGrid(cmdVisitors, tableVisitors, dataGridViewVisitors, 1, ref flagWait);
            }
        }

        private void buttonAddVisitor_Click(object sender, EventArgs e) => addEditVisitors(false);

        private void buttonEditVisitor_Click(object sender, EventArgs e) => addEditVisitors(true);

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbService.DeleteRecord(dataGridViewVisitors.SelectedRows[0].Cells[0].Value.ToString(), "DELETE FROM visitors WHERE id = @id");
                if (!flagWait) dbService.LoadDataGrid(cmdVisitors, tableVisitors, dataGridViewVisitors, 1, ref flagWait);
            }
        }

        #endregion

        #region Services

        private void addEditServices(bool flag)
        {
            ContextServices contextServices = new ContextServices();
            string[] param = new string[3];
            if (flag)
            {
                contextServices.Text = "Изменение услуги";
                contextServices.textBoxService.Text = dataGridViewService.SelectedRows[0].Cells[1].Value.ToString();
                contextServices.textBoxPrice.Text = dataGridViewService.SelectedRows[0].Cells[2].Value.ToString();
                param[2] = dataGridViewService.SelectedRows[0].Cells[0].Value.ToString();
            }
            if (contextServices.ShowDialog() == DialogResult.OK)
            {
                param[0] = contextServices.textBoxService.Text;
                param[1] = contextServices.textBoxPrice.Text;
                dbService.OperationOnRecord(flag ? "UPDATE services SET service_name = @service, price = @priceService WHERE id = @id" : "INSERT INTO `services`(`id`, `service_name`, `price`) VALUES (NULL,@service,@priceService)", param);
                if (!flagWait) dbService.LoadDataGrid(cmdService, tableService, dataGridViewService, 1, ref flagWait);
            }
        }

        private void buttonAddService_Click(object sender, EventArgs e) => addEditServices(false);
        private void buttonEditService_Click(object sender, EventArgs e) => addEditServices(true);

        private void buttonDeleteService_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить данную запись?", "Удаление...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dbService.DeleteRecord(dataGridViewService.SelectedRows[0].Cells[0].Value.ToString(), "DELETE FROM services WHERE id = @id");
                if (!flagWait) dbService.LoadDataGrid(cmdService, tableService, dataGridViewService, 1, ref flagWait);
            }
        }

        #endregion

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
