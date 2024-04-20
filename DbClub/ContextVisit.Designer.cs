namespace DbClub
{
    partial class ContextVisit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            checkBoxEnd = new CheckBox();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            comboBoxComp = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            comboBoxVisitors = new ComboBox();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            butEditCar = new Button();
            butAddCar = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(checkBoxEnd);
            panel1.Controls.Add(dateTimePickerEnd);
            panel1.Controls.Add(dateTimePickerStart);
            panel1.Controls.Add(comboBoxComp);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxVisitors);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 282);
            panel1.TabIndex = 0;
            // 
            // checkBoxEnd
            // 
            checkBoxEnd.AutoSize = true;
            checkBoxEnd.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBoxEnd.Location = new Point(14, 150);
            checkBoxEnd.Name = "checkBoxEnd";
            checkBoxEnd.Size = new Size(223, 37);
            checkBoxEnd.TabIndex = 19;
            checkBoxEnd.Text = "Дата окончания";
            checkBoxEnd.UseVisualStyleBackColor = true;
            checkBoxEnd.CheckedChanged += checkBoxEnd_CheckedChanged;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerEnd.Enabled = false;
            dateTimePickerEnd.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.Location = new Point(313, 146);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(244, 39);
            dateTimePickerEnd.TabIndex = 18;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CustomFormat = "dd.MM.yyyy HH:mm";
            dateTimePickerStart.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(313, 101);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(244, 39);
            dateTimePickerStart.TabIndex = 18;
            // 
            // comboBoxComp
            // 
            comboBoxComp.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxComp.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxComp.FormattingEnabled = true;
            comboBoxComp.Location = new Point(179, 56);
            comboBoxComp.Name = "comboBoxComp";
            comboBoxComp.Size = new Size(378, 39);
            comboBoxComp.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(14, 107);
            label3.Name = "label3";
            label3.Size = new Size(162, 33);
            label3.TabIndex = 16;
            label3.Text = "Дата начала:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(14, 59);
            label2.Name = "label2";
            label2.Size = new Size(159, 33);
            label2.TabIndex = 16;
            label2.Text = "Компьютер:";
            // 
            // comboBoxVisitors
            // 
            comboBoxVisitors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVisitors.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxVisitors.FormattingEnabled = true;
            comboBoxVisitors.Location = new Point(179, 11);
            comboBoxVisitors.Name = "comboBoxVisitors";
            comboBoxVisitors.Size = new Size(378, 39);
            comboBoxVisitors.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(110, 33);
            label1.TabIndex = 16;
            label1.Text = "Клиент:";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(butEditCar, 0, 0);
            tableLayoutPanel5.Controls.Add(butAddCar, 0, 0);
            tableLayoutPanel5.Location = new Point(5, 210);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(554, 55);
            tableLayoutPanel5.TabIndex = 15;
            // 
            // butEditCar
            // 
            butEditCar.BackColor = Color.FromArgb(210, 74, 74);
            butEditCar.DialogResult = DialogResult.Cancel;
            butEditCar.Dock = DockStyle.Fill;
            butEditCar.FlatAppearance.BorderSize = 0;
            butEditCar.FlatStyle = FlatStyle.Flat;
            butEditCar.Font = new Font("Marker Felt", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butEditCar.ForeColor = Color.FromArgb(239, 239, 239);
            butEditCar.Image = Properties.Resources.IconCancel;
            butEditCar.ImageAlign = ContentAlignment.MiddleLeft;
            butEditCar.Location = new Point(297, 3);
            butEditCar.Margin = new Padding(20, 3, 20, 3);
            butEditCar.Name = "butEditCar";
            butEditCar.Padding = new Padding(10, 0, 0, 0);
            butEditCar.Size = new Size(237, 49);
            butEditCar.TabIndex = 1;
            butEditCar.Text = "Отмена";
            butEditCar.TextAlign = ContentAlignment.MiddleRight;
            butEditCar.UseVisualStyleBackColor = false;
            // 
            // butAddCar
            // 
            butAddCar.BackColor = Color.FromArgb(210, 74, 74);
            butAddCar.Dock = DockStyle.Fill;
            butAddCar.FlatAppearance.BorderSize = 0;
            butAddCar.FlatStyle = FlatStyle.Flat;
            butAddCar.Font = new Font("Marker Felt", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butAddCar.ForeColor = Color.FromArgb(239, 239, 239);
            butAddCar.Image = Properties.Resources.IconEnter;
            butAddCar.ImageAlign = ContentAlignment.MiddleLeft;
            butAddCar.Location = new Point(20, 3);
            butAddCar.Margin = new Padding(20, 3, 20, 3);
            butAddCar.Name = "butAddCar";
            butAddCar.Padding = new Padding(10, 0, 0, 0);
            butAddCar.Size = new Size(237, 49);
            butAddCar.TabIndex = 0;
            butAddCar.Text = "Подтвердить";
            butAddCar.TextAlign = ContentAlignment.MiddleRight;
            butAddCar.UseVisualStyleBackColor = false;
            butAddCar.Click += butAddCar_Click;
            // 
            // ContextVisit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(586, 305);
            Controls.Add(panel1);
            Name = "ContextVisit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление посещения";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button butEditCar;
        private Button butAddCar;
        private Label label1;
        private Label label2;
        private Label label3;
        public ComboBox comboBoxVisitors;
        public DateTimePicker dateTimePickerStart;
        public ComboBox comboBoxComp;
        public DateTimePicker dateTimePickerEnd;
        public CheckBox checkBoxEnd;
    }
}