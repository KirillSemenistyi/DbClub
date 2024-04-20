namespace DbClub
{
    partial class ContextServices
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            textBoxService = new TextBox();
            label1 = new Label();
            textBoxPrice = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(textBoxService);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxPrice);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 206);
            panel1.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Location = new Point(8, 134);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(695, 68);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(210, 74, 74);
            button1.DialogResult = DialogResult.Cancel;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.FromArgb(239, 239, 239);
            button1.Image = Properties.Resources.IconCancel;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(372, 4);
            button1.Margin = new Padding(25, 4, 25, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 0, 0);
            button1.Size = new Size(298, 60);
            button1.TabIndex = 1;
            button1.Text = "Отмена";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(210, 74, 74);
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.FromArgb(239, 239, 239);
            button2.Image = Properties.Resources.IconEnter;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(25, 4);
            button2.Margin = new Padding(25, 4, 25, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(12, 0, 0, 0);
            button2.Size = new Size(297, 60);
            button2.TabIndex = 0;
            button2.Text = "Подтвердить";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxService
            // 
            textBoxService.Font = new Font("Times New Roman", 16.2F);
            textBoxService.Location = new Point(262, 18);
            textBoxService.Name = "textBoxService";
            textBoxService.Size = new Size(440, 45);
            textBoxService.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F);
            label1.Location = new Point(3, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 37);
            label1.TabIndex = 0;
            label1.Text = "Услуга:";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Times New Roman", 16.2F);
            textBoxPrice.Location = new Point(262, 77);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(440, 45);
            textBoxPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 16.2F);
            label2.Location = new Point(3, 80);
            label2.Name = "label2";
            label2.Size = new Size(184, 37);
            label2.TabIndex = 1;
            label2.Text = "Цена (руб.):";
            // 
            // ContextServices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(732, 230);
            Controls.Add(panel1);
            Name = "ContextServices";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление услуги";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        protected internal TextBox textBoxService;
        private Label label1;
        public TextBox textBoxPrice;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}