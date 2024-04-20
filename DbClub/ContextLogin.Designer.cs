namespace DbClub
{
    partial class ContextLogin
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            textBoxLog = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBoxPass = new TextBox();
            butEnter = new Button();
            butEye = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            button3 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.CyperX1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(135, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 119);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxLog
            // 
            textBoxLog.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLog.Location = new Point(208, 188);
            textBoxLog.Name = "textBoxLog";
            textBoxLog.Size = new Size(356, 39);
            textBoxLog.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.IconLogin;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(128, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 50);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.IconPass;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(135, 246);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 50);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBoxPass
            // 
            textBoxPass.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPass.Location = new Point(208, 257);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(296, 39);
            textBoxPass.TabIndex = 1;
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // butEnter
            // 
            butEnter.BackColor = Color.FromArgb(187, 32, 38);
            butEnter.FlatAppearance.BorderSize = 0;
            butEnter.FlatStyle = FlatStyle.Flat;
            butEnter.Font = new Font("Nautilus Pompilius", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            butEnter.ForeColor = Color.White;
            butEnter.Location = new Point(208, 342);
            butEnter.Name = "butEnter";
            butEnter.Size = new Size(241, 57);
            butEnter.TabIndex = 2;
            butEnter.Text = "Войти";
            butEnter.UseVisualStyleBackColor = false;
            butEnter.Click += butEnter_Click;
            // 
            // butEye
            // 
            butEye.BackColor = Color.Transparent;
            butEye.BackgroundImage = Properties.Resources.invisible1;
            butEye.BackgroundImageLayout = ImageLayout.Stretch;
            butEye.FlatAppearance.BorderSize = 0;
            butEye.FlatStyle = FlatStyle.Flat;
            butEye.Font = new Font("Nautilus Pompilius", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            butEye.ForeColor = Color.Transparent;
            butEye.Location = new Point(517, 252);
            butEye.Name = "butEye";
            butEye.Size = new Size(47, 49);
            butEye.TabIndex = 2;
            butEye.UseVisualStyleBackColor = false;
            butEye.Click += butEye_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button3, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(210, 74, 74);
            button3.Dock = DockStyle.Fill;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Marker Felt", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.FromArgb(239, 239, 239);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 3);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(44, 94);
            button3.TabIndex = 3;
            button3.Tag = "2";
            button3.Text = "Поставки";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(210, 74, 74);
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Marker Felt", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.FromArgb(239, 239, 239);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(44, 94);
            button2.TabIndex = 2;
            button2.Tag = "3";
            button2.Text = "Заказы";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            // 
            // ContextLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(705, 411);
            Controls.Add(butEye);
            Controls.Add(butEnter);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLog);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContextLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosed += ContextLogin_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxLog;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBoxPass;
        private Button butEnter;
        private Button butEye;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
    }
}