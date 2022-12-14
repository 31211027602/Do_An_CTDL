namespace Quanlyhoso
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMahs = new System.Windows.Forms.TextBox();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTimkiemtheotime = new System.Windows.Forms.Button();
            this.dtpNgaylam = new System.Windows.Forms.DateTimePicker();
            this.dtpTimkiemtheomocA = new System.Windows.Forms.DateTimePicker();
            this.dtpTimkiemtheomocB = new System.Windows.Forms.DateTimePicker();
            this.dataGridHoso = new System.Windows.Forms.DataGridView();
            this.btnTimkiemtheoten = new System.Windows.Forms.Button();
            this.txtTimkiemtheoten = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoso)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hồ sơ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày làm";
            // 
            // txtMahs
            // 
            this.txtMahs.Location = new System.Drawing.Point(81, 10);
            this.txtMahs.Name = "txtMahs";
            this.txtMahs.Size = new System.Drawing.Size(100, 22);
            this.txtMahs.TabIndex = 5;
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(393, 10);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(100, 22);
            this.txtGioitinh.TabIndex = 7;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(393, 46);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(100, 22);
            this.txtLuong.TabIndex = 8;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(82, 46);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(245, 22);
            this.txtHoten.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(546, 46);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tìm kiếm theo tên:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tìm kiếm theo thời gian:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "từ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "đến";
            // 
            // btnTimkiemtheotime
            // 
            this.btnTimkiemtheotime.Location = new System.Drawing.Point(494, 139);
            this.btnTimkiemtheotime.Name = "btnTimkiemtheotime";
            this.btnTimkiemtheotime.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiemtheotime.TabIndex = 24;
            this.btnTimkiemtheotime.Text = "Tìm";
            this.btnTimkiemtheotime.UseVisualStyleBackColor = true;
            this.btnTimkiemtheotime.Click += new System.EventHandler(this.btnTimkiemtheotime_Click);
            // 
            // dtpNgaylam
            // 
            this.dtpNgaylam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylam.Location = new System.Drawing.Point(589, 10);
            this.dtpNgaylam.Name = "dtpNgaylam";
            this.dtpNgaylam.Size = new System.Drawing.Size(119, 22);
            this.dtpNgaylam.TabIndex = 27;
            // 
            // dtpTimkiemtheomocA
            // 
            this.dtpTimkiemtheomocA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimkiemtheomocA.Location = new System.Drawing.Point(188, 139);
            this.dtpTimkiemtheomocA.Name = "dtpTimkiemtheomocA";
            this.dtpTimkiemtheomocA.Size = new System.Drawing.Size(129, 22);
            this.dtpTimkiemtheomocA.TabIndex = 28;
            // 
            // dtpTimkiemtheomocB
            // 
            this.dtpTimkiemtheomocB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTimkiemtheomocB.Location = new System.Drawing.Point(359, 139);
            this.dtpTimkiemtheomocB.Name = "dtpTimkiemtheomocB";
            this.dtpTimkiemtheomocB.Size = new System.Drawing.Size(129, 22);
            this.dtpTimkiemtheomocB.TabIndex = 29;
            // 
            // dataGridHoso
            // 
            this.dataGridHoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHoso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridHoso.Location = new System.Drawing.Point(0, 218);
            this.dataGridHoso.Name = "dataGridHoso";
            this.dataGridHoso.RowHeadersWidth = 51;
            this.dataGridHoso.RowTemplate.Height = 24;
            this.dataGridHoso.Size = new System.Drawing.Size(748, 232);
            this.dataGridHoso.TabIndex = 30;
            // 
            // btnTimkiemtheoten
            // 
            this.btnTimkiemtheoten.Location = new System.Drawing.Point(384, 100);
            this.btnTimkiemtheoten.Name = "btnTimkiemtheoten";
            this.btnTimkiemtheoten.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiemtheoten.TabIndex = 32;
            this.btnTimkiemtheoten.Text = "Tìm";
            this.btnTimkiemtheoten.UseVisualStyleBackColor = true;
            this.btnTimkiemtheoten.Click += new System.EventHandler(this.btnTimkiemtheoten_Click);
            // 
            // txtTimkiemtheoten
            // 
            this.txtTimkiemtheoten.Location = new System.Drawing.Point(133, 100);
            this.txtTimkiemtheoten.Name = "txtTimkiemtheoten";
            this.txtTimkiemtheoten.Size = new System.Drawing.Size(245, 22);
            this.txtTimkiemtheoten.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 450);
            this.Controls.Add(this.txtTimkiemtheoten);
            this.Controls.Add(this.btnTimkiemtheoten);
            this.Controls.Add(this.dataGridHoso);
            this.Controls.Add(this.dtpTimkiemtheomocB);
            this.Controls.Add(this.dtpTimkiemtheomocA);
            this.Controls.Add(this.dtpNgaylam);
            this.Controls.Add(this.btnTimkiemtheotime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtGioitinh);
            this.Controls.Add(this.txtMahs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "QUẢN LÝ HỒ SƠ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHoso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMahs;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTimkiemtheotime;
        private System.Windows.Forms.DateTimePicker dtpNgaylam;
        private System.Windows.Forms.DateTimePicker dtpTimkiemtheomocA;
        private System.Windows.Forms.DateTimePicker dtpTimkiemtheomocB;
        private System.Windows.Forms.DataGridView dataGridHoso;
        private System.Windows.Forms.Button btnTimkiemtheoten;
        private System.Windows.Forms.TextBox txtTimkiemtheoten;
    }
}

