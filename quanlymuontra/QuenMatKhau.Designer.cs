namespace quanlymuontra
{
    partial class Form8
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
            txtpass2 = new TextBox();
            label5 = new Label();
            hienmatkhau = new CheckBox();
            label4 = new Label();
            label1 = new Label();
            doimatkhau = new Button();
            email = new TextBox();
            button1 = new Button();
            txtpass = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtpass2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(hienmatkhau);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(doimatkhau);
            panel1.Controls.Add(email);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtpass);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(47, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 482);
            panel1.TabIndex = 8;
            // 
            // txtpass2
            // 
            txtpass2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass2.Location = new Point(345, 235);
            txtpass2.Name = "txtpass2";
            txtpass2.PasswordChar = '*';
            txtpass2.Size = new Size(388, 32);
            txtpass2.TabIndex = 13;
            txtpass2.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 24F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(73, 235);
            label5.Name = "label5";
            label5.Size = new Size(266, 36);
            label5.TabIndex = 14;
            label5.Text = "Nhập Lại Mật Khẩu";
            label5.Visible = false;
            // 
            // hienmatkhau
            // 
            hienmatkhau.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hienmatkhau.AutoSize = true;
            hienmatkhau.BackColor = Color.Transparent;
            hienmatkhau.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hienmatkhau.ForeColor = Color.White;
            hienmatkhau.Location = new Point(583, 279);
            hienmatkhau.Name = "hienmatkhau";
            hienmatkhau.Size = new Size(150, 27);
            hienmatkhau.TabIndex = 12;
            hienmatkhau.Text = "Hiện mật khẩu";
            hienmatkhau.UseVisualStyleBackColor = false;
            hienmatkhau.Visible = false;
            hienmatkhau.CheckedChanged += hienmatkhau_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Times New Roman", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(246, 20);
            label4.Name = "label4";
            label4.Size = new Size(462, 72);
            label4.TabIndex = 7;
            label4.Text = "Quên Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Times New Roman", 24F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(249, 138);
            label1.Name = "label1";
            label1.Size = new Size(90, 36);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // doimatkhau
            // 
            doimatkhau.BackColor = Color.FromArgb(34, 55, 113);
            doimatkhau.FlatAppearance.BorderSize = 0;
            doimatkhau.FlatStyle = FlatStyle.Flat;
            doimatkhau.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doimatkhau.ForeColor = Color.White;
            doimatkhau.Location = new Point(333, 391);
            doimatkhau.Name = "doimatkhau";
            doimatkhau.Size = new Size(255, 46);
            doimatkhau.TabIndex = 6;
            doimatkhau.Text = "Đổi Mật Khẩu";
            doimatkhau.UseVisualStyleBackColor = false;
            doimatkhau.Visible = false;
            doimatkhau.Click += doimatkhau_Click;
            doimatkhau.MouseLeave += doimatkhau_MouseLeave;
            doimatkhau.MouseMove += doimatkhau_MouseMove;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            email.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(345, 138);
            email.Name = "email";
            email.Size = new Size(388, 32);
            email.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 55, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(333, 339);
            button1.Name = "button1";
            button1.Size = new Size(255, 46);
            button1.TabIndex = 5;
            button1.Text = "Kiểm Tra Email";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseMove += button1_MouseMove;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpass.Location = new Point(345, 187);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.Size = new Size(388, 32);
            txtpass.TabIndex = 1;
            txtpass.Visible = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(345, 283);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 4;
            label3.Text = "Quay Lại Đăng Nhặp";
            label3.Click += label3_Click_1;
            label3.MouseLeave += label3_MouseLeave;
            label3.MouseMove += label3_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 24F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 187);
            label2.Name = "label2";
            label2.Size = new Size(140, 36);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            label2.Visible = false;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Picture1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1021, 574);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private CheckBox hienmatkhau;
        private Label label4;
        private Label label1;
        private Button doimatkhau;
        private TextBox email;
        private Button button1;
        private TextBox txtpass;
        private Label label3;
        private Label label2;
        private TextBox txtpass2;
        private Label label5;
    }
}