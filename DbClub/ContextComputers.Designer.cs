namespace DbClub
{
    partial class ContextComputers
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxCompName = new TextBox();
            textBoxSpecifications = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            butCancel = new Button();
            butAddComp = new Button();
            comboBoxStatus = new ComboBox();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(159, 37);
            label1.TabIndex = 0;
            label1.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F);
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(253, 37);
            label2.TabIndex = 1;
            label2.Text = "Характеристики:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F);
            label3.Location = new Point(3, 244);
            label3.Name = "label3";
            label3.Size = new Size(120, 37);
            label3.TabIndex = 2;
            label3.Text = "Статус:";
            // 
            // textBoxCompName
            // 
            textBoxCompName.Font = new Font("Times New Roman", 16.2F);
            textBoxCompName.Location = new Point(262, 18);
            textBoxCompName.Name = "textBoxCompName";
            textBoxCompName.Size = new Size(440, 45);
            textBoxCompName.TabIndex = 3;
            // 
            // textBoxSpecifications
            // 
            textBoxSpecifications.Font = new Font("Times New Roman", 16.2F);
            textBoxSpecifications.Location = new Point(262, 77);
            textBoxSpecifications.Multiline = true;
            textBoxSpecifications.Name = "textBoxSpecifications";
            textBoxSpecifications.Size = new Size(440, 145);
            textBoxSpecifications.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(comboBoxStatus);
            panel1.Controls.Add(textBoxCompName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxSpecifications);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 380);
            panel1.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.Controls.Add(butCancel, 0, 0);
            tableLayoutPanel5.Controls.Add(butAddComp, 0, 0);
            tableLayoutPanel5.Location = new Point(8, 302);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(695, 69);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // butCancel
            // 
            butCancel.BackColor = Color.FromArgb(210, 74, 74);
            butCancel.DialogResult = DialogResult.Cancel;
            butCancel.Dock = DockStyle.Fill;
            butCancel.FlatAppearance.BorderSize = 0;
            butCancel.FlatStyle = FlatStyle.Flat;
            butCancel.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butCancel.ForeColor = Color.FromArgb(239, 239, 239);
            butCancel.Image = Properties.Resources.IconCancel;
            butCancel.ImageAlign = ContentAlignment.MiddleLeft;
            butCancel.Location = new Point(372, 4);
            butCancel.Margin = new Padding(25, 4, 25, 4);
            butCancel.Name = "butCancel";
            butCancel.Padding = new Padding(12, 0, 0, 0);
            butCancel.Size = new Size(298, 61);
            butCancel.TabIndex = 1;
            butCancel.Text = "Отмена";
            butCancel.TextAlign = ContentAlignment.MiddleRight;
            butCancel.UseVisualStyleBackColor = false;
            // 
            // butAddComp
            // 
            butAddComp.BackColor = Color.FromArgb(210, 74, 74);
            butAddComp.Dock = DockStyle.Fill;
            butAddComp.FlatAppearance.BorderSize = 0;
            butAddComp.FlatStyle = FlatStyle.Flat;
            butAddComp.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butAddComp.ForeColor = Color.FromArgb(239, 239, 239);
            butAddComp.Image = Properties.Resources.IconEnter;
            butAddComp.ImageAlign = ContentAlignment.MiddleLeft;
            butAddComp.Location = new Point(25, 4);
            butAddComp.Margin = new Padding(25, 4, 25, 4);
            butAddComp.Name = "butAddComp";
            butAddComp.Padding = new Padding(12, 0, 0, 0);
            butAddComp.Size = new Size(297, 61);
            butAddComp.TabIndex = 0;
            butAddComp.Text = "Подтвердить";
            butAddComp.TextAlign = ContentAlignment.MiddleRight;
            butAddComp.UseVisualStyleBackColor = false;
            butAddComp.Click += butAddComp_Click;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Times New Roman", 16.2F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "available", "occupied", "maintenance" });
            comboBoxStatus.Location = new Point(262, 237);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(443, 44);
            comboBoxStatus.TabIndex = 5;
            // 
            // ContextComputers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(732, 404);
            Controls.Add(panel1);
            Name = "ContextComputers";
            Text = "Добавление компьютера";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel5;
        private Button butCancel;
        private Button butAddComp;
        public TextBox textBoxCompName;
        public TextBox textBoxSpecifications;
        public ComboBox comboBoxStatus;
    }
}