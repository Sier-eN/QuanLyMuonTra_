namespace quanlymuontra
{
    partial class Form5
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            tg = new ComboBox();
            themtl = new ComboBox();
            button4 = new Button();
            trangthai = new ComboBox();
            label6 = new Label();
            nxb = new DateTimePicker();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            tensach = new TextBox();
            dataGridView1 = new DataGridView();
            MS = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(34, 55, 113);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(23, 284);
            button1.Name = "button1";
            button1.Size = new Size(136, 53);
            button1.TabIndex = 43;
            button1.Text = "Thêm Sách";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseMove += button1_MouseMove;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(32, 80);
            label5.Name = "label5";
            label5.Size = new Size(85, 21);
            label5.TabIndex = 33;
            label5.Text = "Tên Sách:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(34, 55, 113);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 343);
            button2.Name = "button2";
            button2.Size = new Size(136, 53);
            button2.TabIndex = 44;
            button2.Text = "Xóa Sách";
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
            button3.Location = new Point(169, 284);
            button3.Name = "button3";
            button3.Size = new Size(136, 53);
            button3.TabIndex = 45;
            button3.Text = "Cập Nhật";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseMove += button3_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 33, 69);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(tg);
            panel1.Controls.Add(themtl);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(trangthai);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(nxb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tensach);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 573);
            panel1.TabIndex = 48;
            // 
            // tg
            // 
            tg.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tg.FormattingEnabled = true;
            tg.Location = new Point(165, 116);
            tg.Name = "tg";
            tg.Size = new Size(140, 23);
            tg.TabIndex = 59;
            tg.SelectedIndexChanged += tg_SelectedIndexChanged;
            // 
            // themtl
            // 
            themtl.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            themtl.FormattingEnabled = true;
            themtl.Location = new Point(165, 154);
            themtl.Name = "themtl";
            themtl.Size = new Size(140, 23);
            themtl.TabIndex = 58;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(34, 55, 113);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(169, 343);
            button4.Name = "button4";
            button4.Size = new Size(136, 53);
            button4.TabIndex = 57;
            button4.Text = "Xóa DL";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // trangthai
            // 
            trangthai.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trangthai.FormattingEnabled = true;
            trangthai.Items.AddRange(new object[] { "Có Thể Mượn", "Không Thể Mượn" });
            trangthai.Location = new Point(165, 193);
            trangthai.Name = "trangthai";
            trangthai.Size = new Size(112, 23);
            trangthai.TabIndex = 56;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 192);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 55;
            label6.Text = "Trạng Thái:";
            // 
            // nxb
            // 
            nxb.CustomFormat = "dd/MM/yyyy";
            nxb.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nxb.Format = DateTimePickerFormat.Custom;
            nxb.Location = new Point(165, 231);
            nxb.Name = "nxb";
            nxb.Size = new Size(82, 21);
            nxb.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(32, 231);
            label7.Name = "label7";
            label7.Size = new Size(127, 21);
            label7.TabIndex = 53;
            label7.Text = "Ngày Xuất Bản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 156);
            label2.Name = "label2";
            label2.Size = new Size(129, 21);
            label2.TabIndex = 51;
            label2.Text = "Thêm Thể Loại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 116);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 49;
            label1.Text = "Thêm Tác Giả:";
            // 
            // tensach
            // 
            tensach.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tensach.Location = new Point(165, 81);
            tensach.Name = "tensach";
            tensach.Size = new Size(140, 21);
            tensach.TabIndex = 48;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(338, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(34, 55, 113);
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Size = new Size(703, 573);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MS
            // 
            MS.DataPropertyName = "masach";
            MS.HeaderText = "MS";
            MS.Name = "MS";
            MS.ReadOnly = true;
            MS.Width = 40;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column2.DataPropertyName = "tensach";
            Column2.FillWeight = 98.68021F;
            Column2.HeaderText = "Tên Sách";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "tacgia";
            Column3.FillWeight = 98.68021F;
            Column3.HeaderText = "Tác Giả";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "theloai";
            Column4.FillWeight = 98.68021F;
            Column4.HeaderText = "Thể Loại";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ngayxuatban";
            Column5.FillWeight = 98.68021F;
            Column5.HeaderText = "NXB";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 93;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.DataPropertyName = "trangthai";
            Column6.FillWeight = 98.68021F;
            Column6.HeaderText = "Trạng Thái";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(319, 181);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 60;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(66, 96, 206);
            ClientSize = new Size(1053, 597);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label5;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private TextBox tensach;
        private Label label2;
        private Label label1;
        private DateTimePicker nxb;
        private Label label7;
        private ComboBox trangthai;
        private Label label6;
        private Button button4;
        private ComboBox themtl;
        private DataGridView dataGridView1;
        private ComboBox tg;
        private DataGridViewTextBoxColumn MS;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DateTimePicker dateTimePicker1;
    }
}