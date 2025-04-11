namespace quanlymuontra
{
    partial class trangchu
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            MS = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tg = new ComboBox();
            themtl = new ComboBox();
            trangthai = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            tensach = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MS, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle8.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView1.Location = new Point(12, 169);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle9.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.Size = new Size(1029, 404);
            dataGridView1.TabIndex = 29;
            // 
            // MS
            // 
            MS.DataPropertyName = "masach";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle2.ForeColor = Color.White;
            MS.DefaultCellStyle = dataGridViewCellStyle2;
            MS.HeaderText = "MS";
            MS.Name = "MS";
            MS.ReadOnly = true;
            MS.Width = 35;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.DataPropertyName = "tensach";
            dataGridViewCellStyle3.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle3.ForeColor = Color.White;
            Column2.DefaultCellStyle = dataGridViewCellStyle3;
            Column2.FillWeight = 98.68021F;
            Column2.HeaderText = "Tên Sách";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "tacgia";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle4.ForeColor = Color.White;
            Column3.DefaultCellStyle = dataGridViewCellStyle4;
            Column3.FillWeight = 98.68021F;
            Column3.HeaderText = "Tác Giả";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "theloai";
            dataGridViewCellStyle5.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle5.ForeColor = Color.White;
            Column4.DefaultCellStyle = dataGridViewCellStyle5;
            Column4.FillWeight = 98.68021F;
            Column4.HeaderText = "Thể Loại";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 175;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ngayxuatban";
            dataGridViewCellStyle6.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle6.ForeColor = Color.White;
            Column5.DefaultCellStyle = dataGridViewCellStyle6;
            Column5.FillWeight = 98.68021F;
            Column5.HeaderText = "NXB";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.DataPropertyName = "trangthai";
            dataGridViewCellStyle7.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle7.ForeColor = Color.White;
            Column6.DefaultCellStyle = dataGridViewCellStyle7;
            Column6.FillWeight = 98.68021F;
            Column6.HeaderText = "Trạng Thái";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // tg
            // 
            tg.Font = new Font("Times New Roman", 15.75F);
            tg.FormattingEnabled = true;
            tg.Location = new Point(12, 97);
            tg.Name = "tg";
            tg.Size = new Size(241, 31);
            tg.TabIndex = 68;
            tg.SelectedIndexChanged += tg_SelectedIndexChanged;
            // 
            // themtl
            // 
            themtl.Font = new Font("Times New Roman", 15.75F);
            themtl.FormattingEnabled = true;
            themtl.Location = new Point(269, 97);
            themtl.Name = "themtl";
            themtl.Size = new Size(253, 31);
            themtl.TabIndex = 67;
            // 
            // trangthai
            // 
            trangthai.Font = new Font("Times New Roman", 15.75F);
            trangthai.FormattingEnabled = true;
            trangthai.Items.AddRange(new object[] { "Có Thể Mượn", "Không Thể Mượn" });
            trangthai.Location = new Point(539, 97);
            trangthai.Name = "trangthai";
            trangthai.Size = new Size(180, 31);
            trangthai.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 15.75F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(539, 71);
            label6.Name = "label6";
            label6.Size = new Size(105, 23);
            label6.TabIndex = 65;
            label6.Text = "Trạng Thái:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(269, 71);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 64;
            label2.Text = "Thể Loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(81, 23);
            label1.TabIndex = 63;
            label1.Text = "Tác Giả:";
            // 
            // tensach
            // 
            tensach.Font = new Font("Times New Roman", 15.75F);
            tensach.Location = new Point(12, 36);
            tensach.Name = "tensach";
            tensach.Size = new Size(239, 32);
            tensach.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(91, 23);
            label5.TabIndex = 61;
            label5.Text = "Tên Sách:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 55, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(756, 85);
            button1.Name = "button1";
            button1.Size = new Size(136, 53);
            button1.TabIndex = 69;
            button1.Text = "Tìm Kiếm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 55, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(898, 85);
            button2.Name = "button2";
            button2.Size = new Size(77, 53);
            button2.TabIndex = 70;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            // 
            // trangchu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 96, 206);
            ClientSize = new Size(1053, 597);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tg);
            Controls.Add(themtl);
            Controls.Add(trangthai);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tensach);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Name = "trangchu";
            Text = "trangchu";
            Load += trangchu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MS;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ComboBox tg;
        private ComboBox themtl;
        private ComboBox trangthai;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox tensach;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}