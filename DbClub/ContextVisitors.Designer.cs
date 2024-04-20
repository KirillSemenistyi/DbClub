using System.Windows.Forms;

namespace DbClub
{
    partial class ContextVisitors
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
            tableLayoutPanel5 = new TableLayoutPanel();
            butCancel = new Button();
            butAddVisitor = new Button();
            panel1 = new Panel();
            textBoxSurname = new TextBox();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            maskedTextBoxPhoneNumber = new MaskedTextBox();
            label4 = new Label();
            textBoxLastname = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.Controls.Add(butCancel, 0, 0);
            tableLayoutPanel5.Controls.Add(butAddVisitor, 0, 0);
            tableLayoutPanel5.Location = new Point(7, 318);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(695, 68);
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
            butCancel.Size = new Size(298, 60);
            butCancel.TabIndex = 1;
            butCancel.Text = "Отмена";
            butCancel.TextAlign = ContentAlignment.MiddleRight;
            butCancel.UseVisualStyleBackColor = false;
            // 
            // butAddVisitor
            // 
            butAddVisitor.BackColor = Color.FromArgb(210, 74, 74);
            butAddVisitor.Dock = DockStyle.Fill;
            butAddVisitor.FlatAppearance.BorderSize = 0;
            butAddVisitor.FlatStyle = FlatStyle.Flat;
            butAddVisitor.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            butAddVisitor.ForeColor = Color.FromArgb(239, 239, 239);
            butAddVisitor.Image = Properties.Resources.IconEnter;
            butAddVisitor.ImageAlign = ContentAlignment.MiddleLeft;
            butAddVisitor.Location = new Point(25, 4);
            butAddVisitor.Margin = new Padding(25, 4, 25, 4);
            butAddVisitor.Name = "butAddVisitor";
            butAddVisitor.Padding = new Padding(12, 0, 0, 0);
            butAddVisitor.Size = new Size(297, 60);
            butAddVisitor.TabIndex = 0;
            butAddVisitor.Text = "Подтвердить";
            butAddVisitor.TextAlign = ContentAlignment.MiddleRight;
            butAddVisitor.UseVisualStyleBackColor = false;
            butAddVisitor.Click += butAddVisitor_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(maskedTextBoxPhoneNumber);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxLastname);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(textBoxSurname);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 393);
            panel1.TabIndex = 6;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Times New Roman", 16.2F);
            textBoxSurname.Location = new Point(262, 18);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(440, 45);
            textBoxSurname.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(155, 37);
            label1.TabIndex = 0;
            label1.Text = "Фамилия:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Times New Roman", 16.2F);
            textBoxName.Location = new Point(262, 77);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(440, 45);
            textBoxName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F);
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(86, 37);
            label2.TabIndex = 1;
            label2.Text = "Имя:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 16.2F);
            label5.Location = new Point(0, 260);
            label5.Name = "label5";
            label5.Size = new Size(252, 37);
            label5.TabIndex = 19;
            label5.Text = "Номер телефона:";
            // 
            // maskedTextBoxPhoneNumber
            // 
            maskedTextBoxPhoneNumber.Font = new Font("Times New Roman", 16.2F);
            maskedTextBoxPhoneNumber.Location = new Point(454, 257);
            maskedTextBoxPhoneNumber.Mask = "7 (999) 000-00-00";
            maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            maskedTextBoxPhoneNumber.Size = new Size(248, 45);
            maskedTextBoxPhoneNumber.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F);
            label4.Location = new Point(3, 141);
            label4.Name = "label4";
            label4.Size = new Size(156, 37);
            label4.TabIndex = 17;
            label4.Text = "Отчество:";
            // 
            // textBoxLastname
            // 
            textBoxLastname.Font = new Font("Times New Roman", 16.2F);
            textBoxLastname.Location = new Point(262, 138);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(440, 45);
            textBoxLastname.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 16.2F);
            label3.Location = new Point(3, 201);
            label3.Name = "label3";
            label3.Size = new Size(98, 37);
            label3.TabIndex = 20;
            label3.Text = "email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Times New Roman", 16.2F);
            textBoxEmail.Location = new Point(262, 198);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(440, 45);
            textBoxEmail.TabIndex = 21;
            // 
            // ContextVisitors
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(732, 417);
            Controls.Add(panel1);
            Name = "ContextVisitors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление посетителя";
            tableLayoutPanel5.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel5;
        private Button butCancel;
        private Button butAddVisitor;
        private Panel panel1;
        private Label label1;
        public TextBox textBoxName;
        private Label label2;
        protected internal TextBox textBoxSurname;
        public MaskedTextBox maskedTextBoxPhoneNumber;
        public TextBox textBoxEmail;
        private Label label3;
        private Label label5;
        public TextBox textBoxLastname;
        private Label label4;
    }
}