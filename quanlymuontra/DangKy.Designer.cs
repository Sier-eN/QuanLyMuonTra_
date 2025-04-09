namespace quanlymuontra
{
    partial class Form7
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
            txttk = new TextBox();
            txtmk = new TextBox();
            label2 = new Label();
            txtemail = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 174);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập:";
            label1.Click += label1_Click;
            // 
            // txttk
            // 
            txttk.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttk.Location = new Point(175, 174);
            txttk.Name = "txttk";
            txttk.Size = new Size(259, 21);
            txttk.TabIndex = 1;
            // 
            // txtmk
            // 
            txtmk.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmk.Location = new Point(175, 213);
            txtmk.Name = "txtmk";
            txtmk.Size = new Size(259, 21);
            txtmk.TabIndex = 3;
            txtmk.TextChanged += txtmk_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(95, 215);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 2;
            label2.Text = "Mật Khẩu:";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(175, 252);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(259, 21);
            txtemail.TabIndex = 7;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(88, 256);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 6;
            label4.Text = "Email/ SĐT:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 55, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(144, 360);
            button1.Name = "button1";
            button1.Size = new Size(249, 56);
            button1.TabIndex = 8;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseMove += button1_MouseMove;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(144, 326);
            label5.Name = "label5";
            label5.Size = new Size(195, 21);
            label5.TabIndex = 9;
            label5.Text = "Quay lại trang đăng nhập";
            label5.Click += label5_Click;
            label5.MouseLeave += label5_MouseLeave;
            label5.MouseMove += label5_MouseMove;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 59);
            label6.Name = "label6";
            label6.Size = new Size(507, 54);
            label6.TabIndex = 10;
            label6.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txttk);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtemail);
            panel1.Controls.Add(txtmk);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(50, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 436);
            panel1.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(319, 290);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(115, 23);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Picture1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(640, 535);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = Color.Black;
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form7";
            Load += Form7_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txttk;
        private TextBox txtmk;
        private Label label2;
        private TextBox txtemail;
        private Label label4;
        private Button button1;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private CheckBox checkBox1;
    }
}