namespace quanlymuontra
{
    partial class qlnd
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Quyền = new DataGridViewTextBoxColumn();
            txtemail = new TextBox();
            label3 = new Label();
            matkhau = new TextBox();
            label2 = new Label();
            taikhoan = new TextBox();
            label5 = new Label();
            quyen = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(19, 33, 69);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 132, 61);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Email, Quyền });
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Size = new Size(1029, 372);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.DataPropertyName = "id";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle2.ForeColor = Color.White;
            ID.DefaultCellStyle = dataGridViewCellStyle2;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 35;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.DataPropertyName = "taikhoan";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle3.ForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.FillWeight = 98.68021F;
            Column2.HeaderText = "Tài Khoản";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "matkhau";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle4.ForeColor = Color.White;
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.FillWeight = 98.68021F;
            Column3.HeaderText = "Mật Khẩu";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle5.ForeColor = Color.White;
            Email.DefaultCellStyle = dataGridViewCellStyle5;
            Email.FillWeight = 98.68021F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 350;
            // 
            // Quyền
            // 
            Quyền.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quyền.DataPropertyName = "quyen";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle6.ForeColor = Color.White;
            Quyền.DefaultCellStyle = dataGridViewCellStyle6;
            Quyền.FillWeight = 98.68021F;
            Quyền.HeaderText = "Quyền";
            Quyền.Name = "Quyền";
            Quyền.ReadOnly = true;
            // 
            // txtemail
            // 
            txtemail.Enabled = false;
            txtemail.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(251, 494);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(256, 32);
            txtemail.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(179, 497);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 59;
            label3.Text = "Email:";
            // 
            // matkhau
            // 
            matkhau.Enabled = false;
            matkhau.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            matkhau.Location = new Point(251, 455);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(256, 32);
            matkhau.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(146, 458);
            label2.Name = "label2";
            label2.Size = new Size(99, 23);
            label2.TabIndex = 57;
            label2.Text = "Mật Khẩu:";
            // 
            // taikhoan
            // 
            taikhoan.Enabled = false;
            taikhoan.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            taikhoan.Location = new Point(251, 417);
            taikhoan.Name = "taikhoan";
            taikhoan.Size = new Size(256, 32);
            taikhoan.TabIndex = 56;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 420);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 55;
            label5.Text = "Tài Khoản:";
            // 
            // quyen
            // 
            quyen.Enabled = false;
            quyen.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quyen.Location = new Point(251, 532);
            quyen.Name = "quyen";
            quyen.Size = new Size(256, 32);
            quyen.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(175, 535);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 61;
            label1.Text = "Quyền:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 55, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(598, 405);
            button1.Name = "button1";
            button1.Size = new Size(214, 53);
            button1.TabIndex = 63;
            button1.Text = "Cấp Quyền ADMIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseMove += button1_MouseMove;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 55, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(598, 464);
            button2.Name = "button2";
            button2.Size = new Size(214, 53);
            button2.TabIndex = 64;
            button2.Text = "Xóa Quyền ADMIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseMove += button2_MouseMove;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(34, 55, 113);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(598, 523);
            button3.Name = "button3";
            button3.Size = new Size(214, 53);
            button3.TabIndex = 65;
            button3.Text = "Xóa Nội Dung";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseMove += button3_MouseMove;
            // 
            // qlnd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 96, 206);
            ClientSize = new Size(1053, 597);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(quyen);
            Controls.Add(label1);
            Controls.Add(txtemail);
            Controls.Add(label3);
            Controls.Add(matkhau);
            Controls.Add(label2);
            Controls.Add(taikhoan);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "qlnd";
            Text = "qlnd";
            Load += qlnd_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Quyền;
        private TextBox txtemail;
        private Label label3;
        private TextBox matkhau;
        private Label label2;
        private TextBox taikhoan;
        private Label label5;
        private TextBox quyen;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}