
namespace QuanLyComTam
{
    partial class fNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanVien));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datetime_ngay = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_manhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaCa = new System.Windows.Forms.Button();
            this.btnXoaCa = new System.Windows.Forms.Button();
            this.btThemCa = new System.Windows.Forms.Button();
            this.tb_makhuvuc = new System.Windows.Forms.TextBox();
            this.tb_tenca = new System.Windows.Forms.TextBox();
            this.tb_maca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_soca = new System.Windows.Forms.TextBox();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.datetime_ngaynhan = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dvg_tinhluong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bntXoaLuong = new System.Windows.Forms.Button();
            this.btnThemLuong = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSuaLuong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_tinhluong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(99, 60);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(976, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datetime_ngay);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_manhanvien);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSuaCa);
            this.tabPage1.Controls.Add(this.btnXoaCa);
            this.tabPage1.Controls.Add(this.btThemCa);
            this.tabPage1.Controls.Add(this.tb_makhuvuc);
            this.tabPage1.Controls.Add(this.tb_tenca);
            this.tabPage1.Controls.Add(this.tb_maca);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(968, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     CA LÀM     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // datetime_ngay
            // 
            this.datetime_ngay.CustomFormat = "dd/MM/yyyy";
            this.datetime_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_ngay.Location = new System.Drawing.Point(634, 104);
            this.datetime_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_ngay.Name = "datetime_ngay";
            this.datetime_ngay.Size = new System.Drawing.Size(300, 22);
            this.datetime_ngay.TabIndex = 35;
            this.datetime_ngay.Value = new System.DateTime(2022, 6, 26, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(470, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Ngày";
            // 
            // tb_manhanvien
            // 
            this.tb_manhanvien.Location = new System.Drawing.Point(634, 63);
            this.tb_manhanvien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_manhanvien.Name = "tb_manhanvien";
            this.tb_manhanvien.Size = new System.Drawing.Size(300, 22);
            this.tb_manhanvien.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.Location = new System.Drawing.Point(470, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Mã Nhân Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCa,
            this.MaNhanVien,
            this.TenCa,
            this.MaKhuVuc,
            this.Ngay});
            this.dataGridView1.Location = new System.Drawing.Point(19, 269);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(916, 329);
            this.dataGridView1.TabIndex = 29;
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã Ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.ReadOnly = true;
            this.MaCa.Width = 125;
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.DataPropertyName = "MaNhanVien";
            this.MaNhanVien.HeaderText = "Mã Nhân Viên";
            this.MaNhanVien.MinimumWidth = 6;
            this.MaNhanVien.Name = "MaNhanVien";
            this.MaNhanVien.ReadOnly = true;
            this.MaNhanVien.Width = 125;
            // 
            // TenCa
            // 
            this.TenCa.DataPropertyName = "TenCa";
            this.TenCa.HeaderText = "Tên Ca";
            this.TenCa.MinimumWidth = 6;
            this.TenCa.Name = "TenCa";
            this.TenCa.ReadOnly = true;
            this.TenCa.Width = 120;
            // 
            // MaKhuVuc
            // 
            this.MaKhuVuc.DataPropertyName = "MaKhuVuc";
            this.MaKhuVuc.HeaderText = "Mã Khu Vực";
            this.MaKhuVuc.MinimumWidth = 6;
            this.MaKhuVuc.Name = "MaKhuVuc";
            this.MaKhuVuc.ReadOnly = true;
            this.MaKhuVuc.Width = 125;
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            this.Ngay.ReadOnly = true;
            this.Ngay.Width = 125;
            // 
            // btnSuaCa
            // 
            this.btnSuaCa.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSuaCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuaCa.ForeColor = System.Drawing.Color.White;
            this.btnSuaCa.Location = new System.Drawing.Point(384, 215);
            this.btnSuaCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaCa.Name = "btnSuaCa";
            this.btnSuaCa.Size = new System.Drawing.Size(185, 47);
            this.btnSuaCa.TabIndex = 28;
            this.btnSuaCa.Text = "Sửa";
            this.btnSuaCa.UseVisualStyleBackColor = false;
            this.btnSuaCa.Click += new System.EventHandler(this.bt_sua_Click_1);
            // 
            // btnXoaCa
            // 
            this.btnXoaCa.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnXoaCa.ForeColor = System.Drawing.Color.White;
            this.btnXoaCa.Location = new System.Drawing.Point(750, 215);
            this.btnXoaCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaCa.Name = "btnXoaCa";
            this.btnXoaCa.Size = new System.Drawing.Size(185, 47);
            this.btnXoaCa.TabIndex = 27;
            this.btnXoaCa.Text = "Xóa";
            this.btnXoaCa.UseVisualStyleBackColor = false;
            this.btnXoaCa.Click += new System.EventHandler(this.bt_xoa_Click_1);
            // 
            // btThemCa
            // 
            this.btThemCa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btThemCa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btThemCa.ForeColor = System.Drawing.Color.White;
            this.btThemCa.Location = new System.Drawing.Point(19, 215);
            this.btThemCa.Margin = new System.Windows.Forms.Padding(4);
            this.btThemCa.Name = "btThemCa";
            this.btThemCa.Size = new System.Drawing.Size(185, 47);
            this.btThemCa.TabIndex = 26;
            this.btThemCa.Text = "Thêm";
            this.btThemCa.UseVisualStyleBackColor = false;
            this.btThemCa.Click += new System.EventHandler(this.bt_them_Click_1);
            // 
            // tb_makhuvuc
            // 
            this.tb_makhuvuc.Location = new System.Drawing.Point(159, 143);
            this.tb_makhuvuc.Margin = new System.Windows.Forms.Padding(4);
            this.tb_makhuvuc.Name = "tb_makhuvuc";
            this.tb_makhuvuc.Size = new System.Drawing.Size(293, 22);
            this.tb_makhuvuc.TabIndex = 25;
            // 
            // tb_tenca
            // 
            this.tb_tenca.Location = new System.Drawing.Point(159, 104);
            this.tb_tenca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tenca.Name = "tb_tenca";
            this.tb_tenca.Size = new System.Drawing.Size(293, 22);
            this.tb_tenca.TabIndex = 24;
            // 
            // tb_maca
            // 
            this.tb_maca.Location = new System.Drawing.Point(159, 65);
            this.tb_maca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maca.Name = "tb_maca";
            this.tb_maca.Size = new System.Drawing.Size(293, 22);
            this.tb_maca.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã Khu Vực";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(19, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên Ca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(19, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mã Ca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(329, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "Quản Lý Ca Làm";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_soca);
            this.tabPage2.Controls.Add(this.tb_tongtien);
            this.tabPage2.Controls.Add(this.datetime_ngaynhan);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.dvg_tinhluong);
            this.tabPage2.Controls.Add(this.bntXoaLuong);
            this.tabPage2.Controls.Add(this.btnThemLuong);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.btnSuaLuong);
            this.tabPage2.Location = new System.Drawing.Point(4, 64);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(968, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TÍNH LƯƠNG";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_soca
            // 
            this.tb_soca.Location = new System.Drawing.Point(196, 130);
            this.tb_soca.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soca.Name = "tb_soca";
            this.tb_soca.Size = new System.Drawing.Size(128, 22);
            this.tb_soca.TabIndex = 48;
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Location = new System.Drawing.Point(196, 167);
            this.tb_tongtien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(128, 22);
            this.tb_tongtien.TabIndex = 47;
            // 
            // datetime_ngaynhan
            // 
            this.datetime_ngaynhan.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.datetime_ngaynhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_ngaynhan.Location = new System.Drawing.Point(515, 89);
            this.datetime_ngaynhan.Margin = new System.Windows.Forms.Padding(4);
            this.datetime_ngaynhan.Name = "datetime_ngaynhan";
            this.datetime_ngaynhan.Size = new System.Drawing.Size(265, 22);
            this.datetime_ngaynhan.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(425, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 45;
            this.label7.Text = "Ngày";
            // 
            // dvg_tinhluong
            // 
            this.dvg_tinhluong.AllowUserToAddRows = false;
            this.dvg_tinhluong.AllowUserToDeleteRows = false;
            this.dvg_tinhluong.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_tinhluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_tinhluong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.SoCa,
            this.NgayNhan,
            this.TongTien,
            this.GhiChu});
            this.dvg_tinhluong.Location = new System.Drawing.Point(13, 294);
            this.dvg_tinhluong.Margin = new System.Windows.Forms.Padding(4);
            this.dvg_tinhluong.Name = "dvg_tinhluong";
            this.dvg_tinhluong.ReadOnly = true;
            this.dvg_tinhluong.RowHeadersWidth = 51;
            this.dvg_tinhluong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvg_tinhluong.Size = new System.Drawing.Size(948, 303);
            this.dvg_tinhluong.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhanVien";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Nhân Viên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // SoCa
            // 
            this.SoCa.DataPropertyName = "SoCa";
            this.SoCa.HeaderText = "Số Ca";
            this.SoCa.MinimumWidth = 6;
            this.SoCa.Name = "SoCa";
            this.SoCa.ReadOnly = true;
            this.SoCa.Width = 125;
            // 
            // NgayNhan
            // 
            this.NgayNhan.DataPropertyName = "NgayNhan";
            this.NgayNhan.HeaderText = "Ngày";
            this.NgayNhan.MinimumWidth = 6;
            this.NgayNhan.Name = "NgayNhan";
            this.NgayNhan.ReadOnly = true;
            this.NgayNhan.Width = 125;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 125;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bntXoaLuong
            // 
            this.bntXoaLuong.BackColor = System.Drawing.Color.Crimson;
            this.bntXoaLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bntXoaLuong.ForeColor = System.Drawing.Color.White;
            this.bntXoaLuong.Location = new System.Drawing.Point(373, 239);
            this.bntXoaLuong.Margin = new System.Windows.Forms.Padding(4);
            this.bntXoaLuong.Name = "bntXoaLuong";
            this.bntXoaLuong.Size = new System.Drawing.Size(132, 47);
            this.bntXoaLuong.TabIndex = 42;
            this.bntXoaLuong.Text = "Xóa";
            this.bntXoaLuong.UseVisualStyleBackColor = false;
            this.bntXoaLuong.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThemLuong
            // 
            this.btnThemLuong.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThemLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnThemLuong.ForeColor = System.Drawing.Color.White;
            this.btnThemLuong.Location = new System.Drawing.Point(8, 241);
            this.btnThemLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemLuong.Name = "btnThemLuong";
            this.btnThemLuong.Size = new System.Drawing.Size(132, 47);
            this.btnThemLuong.TabIndex = 41;
            this.btnThemLuong.Text = "Thêm";
            this.btnThemLuong.UseVisualStyleBackColor = false;
            this.btnThemLuong.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 22);
            this.textBox1.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(8, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Tổng Tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(8, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "Số Ca";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(8, 90);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 23);
            this.label10.TabIndex = 37;
            this.label10.Text = "Mã Nhân Viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(309, 3);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(302, 40);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tính Tiền Lương";
            // 
            // btnSuaLuong
            // 
            this.btnSuaLuong.BackColor = System.Drawing.Color.Orange;
            this.btnSuaLuong.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSuaLuong.ForeColor = System.Drawing.Color.White;
            this.btnSuaLuong.Location = new System.Drawing.Point(191, 241);
            this.btnSuaLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaLuong.Name = "btnSuaLuong";
            this.btnSuaLuong.Size = new System.Drawing.Size(132, 47);
            this.btnSuaLuong.TabIndex = 43;
            this.btnSuaLuong.Text = "Sửa";
            this.btnSuaLuong.UseVisualStyleBackColor = false;
            this.btnSuaLuong.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(40, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // fNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 744);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.fNhanVien_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_tinhluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker datetime_ngay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_manhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.Button btnSuaCa;
        private System.Windows.Forms.Button btnXoaCa;
        private System.Windows.Forms.Button btThemCa;
        private System.Windows.Forms.TextBox tb_makhuvuc;
        private System.Windows.Forms.TextBox tb_tenca;
        private System.Windows.Forms.TextBox tb_maca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_soca;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.DateTimePicker datetime_ngaynhan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dvg_tinhluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button bntXoaLuong;
        private System.Windows.Forms.Button btnThemLuong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSuaLuong;
        private System.Windows.Forms.Button button1;
    }
}