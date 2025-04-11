namespace quanlymuontra
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tensach = new TextBox();
            label5 = new Label();
            nguoimuon = new TextBox();
            label2 = new Label();
            email = new TextBox();
            label3 = new Label();
            trangthai = new TextBox();
            label4 = new Label();
            ngaymuon = new DateTimePicker();
            label7 = new Label();
            hantra = new DateTimePicker();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 27);
            label1.TabIndex = 6;
            label1.Text = "Sách Đang Mượn/ Sách Chưa Trả";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(19, 33, 69);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column8, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.Location = new Point(12, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Size = new Size(1029, 360);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "masach";
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            Column1.DefaultCellStyle = dataGridViewCellStyle2;
            Column1.FillWeight = 3.12823033F;
            Column1.HeaderText = "MS";
            Column1.Name = "Column1";
            Column1.Width = 35;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "iduser";
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            Column7.DefaultCellStyle = dataGridViewCellStyle3;
            Column7.FillWeight = 8.937801F;
            Column7.HeaderText = "Người Mượn";
            Column7.Name = "Column7";
            Column7.Width = 150;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "email";
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            Column8.DefaultCellStyle = dataGridViewCellStyle4;
            Column8.FillWeight = 8.937801F;
            Column8.HeaderText = "Email";
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "tensach";
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle5;
            Column2.FillWeight = 8.937801F;
            Column2.HeaderText = "Tên Sách";
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.DataPropertyName = "trangthai";
            dataGridViewCellStyle6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.White;
            Column3.DefaultCellStyle = dataGridViewCellStyle6;
            Column3.FillWeight = 8.937801F;
            Column3.HeaderText = "Trạng Thái";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ngaymuon";
            dataGridViewCellStyle7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.White;
            Column4.DefaultCellStyle = dataGridViewCellStyle7;
            Column4.FillWeight = 373.096436F;
            Column4.HeaderText = "Ngày Mượn";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ngaytra";
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            Column5.DefaultCellStyle = dataGridViewCellStyle8;
            Column5.FillWeight = 109.616066F;
            Column5.HeaderText = "Ngày Trả";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "hantra";
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            Column6.DefaultCellStyle = dataGridViewCellStyle9;
            Column6.FillWeight = 213.408081F;
            Column6.HeaderText = "Hạn Trả";
            Column6.Name = "Column6";
            // 
            // tensach
            // 
            tensach.Enabled = false;
            tensach.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tensach.Location = new Point(138, 431);
            tensach.Name = "tensach";
            tensach.Size = new Size(256, 32);
            tensach.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 434);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 49;
            label5.Text = "Tên Sách:";
            // 
            // nguoimuon
            // 
            nguoimuon.Enabled = false;
            nguoimuon.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nguoimuon.Location = new Point(138, 469);
            nguoimuon.Name = "nguoimuon";
            nguoimuon.Size = new Size(256, 32);
            nguoimuon.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(8, 472);
            label2.Name = "label2";
            label2.Size = new Size(124, 23);
            label2.TabIndex = 51;
            label2.Text = "Người Mượn:";
            // 
            // email
            // 
            email.Enabled = false;
            email.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.Location = new Point(138, 507);
            email.Name = "email";
            email.Size = new Size(256, 32);
            email.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(66, 510);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 53;
            label3.Text = "Email:";
            // 
            // trangthai
            // 
            trangthai.Enabled = false;
            trangthai.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangthai.Location = new Point(611, 507);
            trangthai.Name = "trangthai";
            trangthai.Size = new Size(158, 32);
            trangthai.TabIndex = 56;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(500, 510);
            label4.Name = "label4";
            label4.Size = new Size(105, 23);
            label4.TabIndex = 55;
            label4.Text = "Trạng Thái:";
            // 
            // ngaymuon
            // 
            ngaymuon.CustomFormat = "dd/MM/yyyy";
            ngaymuon.Enabled = false;
            ngaymuon.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ngaymuon.Format = DateTimePickerFormat.Custom;
            ngaymuon.Location = new Point(611, 431);
            ngaymuon.Name = "ngaymuon";
            ngaymuon.Size = new Size(158, 32);
            ngaymuon.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(491, 434);
            label7.Name = "label7";
            label7.Size = new Size(114, 23);
            label7.TabIndex = 57;
            label7.Text = "Ngày Mượn:";
            // 
            // hantra
            // 
            hantra.CustomFormat = "dd/MM/yyyy";
            hantra.Enabled = false;
            hantra.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hantra.Format = DateTimePickerFormat.Custom;
            hantra.Location = new Point(611, 469);
            hantra.Name = "hantra";
            hantra.Size = new Size(158, 32);
            hantra.TabIndex = 60;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(514, 472);
            label6.Name = "label6";
            label6.Size = new Size(91, 23);
            label6.TabIndex = 59;
            label6.Text = "Ngày Trả:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 55, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(804, 431);
            button1.Name = "button1";
            button1.Size = new Size(214, 53);
            button1.TabIndex = 61;
            button1.Text = "Trả Sách";
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
            button2.Location = new Point(804, 486);
            button2.Name = "button2";
            button2.Size = new Size(214, 53);
            button2.TabIndex = 62;
            button2.Text = "Xóa Thông Tin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseMove += button2_MouseMove;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 96, 206);
            ClientSize = new Size(1053, 597);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hantra);
            Controls.Add(label6);
            Controls.Add(ngaymuon);
            Controls.Add(label7);
            Controls.Add(trangthai);
            Controls.Add(label4);
            Controls.Add(email);
            Controls.Add(label3);
            Controls.Add(nguoimuon);
            Controls.Add(label2);
            Controls.Add(tensach);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox tensach;
        private Label label5;
        private TextBox nguoimuon;
        private Label label2;
        private TextBox email;
        private Label label3;
        private TextBox trangthai;
        private Label label4;
        private DateTimePicker ngaymuon;
        private Label label7;
        private DateTimePicker hantra;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}