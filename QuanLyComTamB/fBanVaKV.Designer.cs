
namespace QuanLyComTam
{
    partial class fBanVaKV
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_find = new System.Windows.Forms.TextBox();
            this.bt_out = new System.Windows.Forms.Button();
            this.bt_find = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.gb_listBan = new System.Windows.Forms.GroupBox();
            this.dgv_listBan = new System.Windows.Forms.DataGridView();
            this.gb_Ban = new System.Windows.Forms.GroupBox();
            this.tb_maKhuVuc = new System.Windows.Forms.TextBox();
            this.tb_tenBan = new System.Windows.Forms.TextBox();
            this.tb_maBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_tenKV = new System.Windows.Forms.TextBox();
            this.tb_idKV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_find_KV = new System.Windows.Forms.TextBox();
            this.bt_out_KV = new System.Windows.Forms.Button();
            this.bt_find_KV = new System.Windows.Forms.Button();
            this.bt_clear_KV = new System.Windows.Forms.Button();
            this.bt_update_KV = new System.Windows.Forms.Button();
            this.bt_add_KV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_listKV = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker4 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_listBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBan)).BeginInit();
            this.gb_Ban.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(111, 60);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 697);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_find);
            this.tabPage1.Controls.Add(this.bt_out);
            this.tabPage1.Controls.Add(this.bt_find);
            this.tabPage1.Controls.Add(this.bt_clear);
            this.tabPage1.Controls.Add(this.bt_update);
            this.tabPage1.Controls.Add(this.bt_add);
            this.tabPage1.Controls.Add(this.gb_listBan);
            this.tabPage1.Controls.Add(this.gb_Ban);
            this.tabPage1.Location = new System.Drawing.Point(4, 64);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 629);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bàn";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tb_find
            // 
            this.tb_find.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_find.Location = new System.Drawing.Point(482, 29);
            this.tb_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find.Name = "tb_find";
            this.tb_find.Size = new System.Drawing.Size(352, 27);
            this.tb_find.TabIndex = 16;
            this.tb_find.Text = "Nhập từ khóa cần tìm";
            this.tb_find.TextChanged += new System.EventHandler(this.tb_find_TextChanged);
            // 
            // bt_out
            // 
            this.bt_out.BackColor = System.Drawing.Color.Crimson;
            this.bt_out.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_out.ForeColor = System.Drawing.Color.White;
            this.bt_out.Location = new System.Drawing.Point(18, 496);
            this.bt_out.Margin = new System.Windows.Forms.Padding(4);
            this.bt_out.Name = "bt_out";
            this.bt_out.Size = new System.Drawing.Size(92, 47);
            this.bt_out.TabIndex = 15;
            this.bt_out.Text = "Thoát";
            this.bt_out.UseVisualStyleBackColor = false;
            this.bt_out.Click += new System.EventHandler(this.bt_out_Click);
            // 
            // bt_find
            // 
            this.bt_find.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_find.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_find.ForeColor = System.Drawing.Color.White;
            this.bt_find.Location = new System.Drawing.Point(861, 18);
            this.bt_find.Margin = new System.Windows.Forms.Padding(4);
            this.bt_find.Name = "bt_find";
            this.bt_find.Size = new System.Drawing.Size(114, 47);
            this.bt_find.TabIndex = 17;
            this.bt_find.Text = "Tìm Kiếm";
            this.bt_find.UseVisualStyleBackColor = false;
            this.bt_find.Click += new System.EventHandler(this.bt_find_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.Crimson;
            this.bt_clear.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_clear.ForeColor = System.Drawing.Color.White;
            this.bt_clear.Location = new System.Drawing.Point(369, 18);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(92, 47);
            this.bt_clear.TabIndex = 14;
            this.bt_clear.Text = "Xóa";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_update.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_update.ForeColor = System.Drawing.Color.White;
            this.bt_update.Location = new System.Drawing.Point(171, 18);
            this.bt_update.Margin = new System.Windows.Forms.Padding(4);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(142, 47);
            this.bt_update.TabIndex = 13;
            this.bt_update.Text = "Cập Nhật";
            this.bt_update.UseVisualStyleBackColor = false;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_add.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_add.ForeColor = System.Drawing.Color.White;
            this.bt_add.Location = new System.Drawing.Point(17, 18);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(92, 47);
            this.bt_add.TabIndex = 12;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // gb_listBan
            // 
            this.gb_listBan.Controls.Add(this.dgv_listBan);
            this.gb_listBan.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_listBan.Location = new System.Drawing.Point(482, 83);
            this.gb_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Name = "gb_listBan";
            this.gb_listBan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_listBan.Size = new System.Drawing.Size(733, 460);
            this.gb_listBan.TabIndex = 10;
            this.gb_listBan.TabStop = false;
            this.gb_listBan.Text = "Danh Sách Bàn";
            this.gb_listBan.Enter += new System.EventHandler(this.gb_listBan_Enter);
            // 
            // dgv_listBan
            // 
            this.dgv_listBan.AllowUserToAddRows = false;
            this.dgv_listBan.AllowUserToDeleteRows = false;
            this.dgv_listBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listBan.Location = new System.Drawing.Point(19, 25);
            this.dgv_listBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listBan.Name = "dgv_listBan";
            this.dgv_listBan.ReadOnly = true;
            this.dgv_listBan.RowHeadersWidth = 51;
            this.dgv_listBan.RowTemplate.Height = 24;
            this.dgv_listBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listBan.Size = new System.Drawing.Size(714, 449);
            this.dgv_listBan.TabIndex = 0;
            this.dgv_listBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listBan_CellContentClick);
            this.dgv_listBan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_listKV_RowPrePaint);
            // 
            // gb_Ban
            // 
            this.gb_Ban.Controls.Add(this.tb_maKhuVuc);
            this.gb_Ban.Controls.Add(this.tb_tenBan);
            this.gb_Ban.Controls.Add(this.tb_maBan);
            this.gb_Ban.Controls.Add(this.label3);
            this.gb_Ban.Controls.Add(this.label2);
            this.gb_Ban.Controls.Add(this.label1);
            this.gb_Ban.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.gb_Ban.Location = new System.Drawing.Point(17, 106);
            this.gb_Ban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Ban.Name = "gb_Ban";
            this.gb_Ban.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Ban.Size = new System.Drawing.Size(421, 279);
            this.gb_Ban.TabIndex = 11;
            this.gb_Ban.TabStop = false;
            this.gb_Ban.Text = "Số Bàn";
            this.gb_Ban.Enter += new System.EventHandler(this.gb_Ban_Enter);
            // 
            // tb_maKhuVuc
            // 
            this.tb_maKhuVuc.Location = new System.Drawing.Point(129, 176);
            this.tb_maKhuVuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_maKhuVuc.Name = "tb_maKhuVuc";
            this.tb_maKhuVuc.Size = new System.Drawing.Size(246, 28);
            this.tb_maKhuVuc.TabIndex = 3;
            this.tb_maKhuVuc.TextChanged += new System.EventHandler(this.tb_maKhuVuc_TextChanged);
            // 
            // tb_tenBan
            // 
            this.tb_tenBan.Location = new System.Drawing.Point(129, 121);
            this.tb_tenBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenBan.Name = "tb_tenBan";
            this.tb_tenBan.Size = new System.Drawing.Size(246, 28);
            this.tb_tenBan.TabIndex = 2;
            // 
            // tb_maBan
            // 
            this.tb_maBan.Location = new System.Drawing.Point(129, 63);
            this.tb_maBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_maBan.Name = "tb_maBan";
            this.tb_maBan.Size = new System.Drawing.Size(246, 28);
            this.tb_maBan.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Khu Vực: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(44, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Bàn: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(44, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Bàn:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_tenKV);
            this.tabPage2.Controls.Add(this.tb_idKV);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tb_find_KV);
            this.tabPage2.Controls.Add(this.bt_out_KV);
            this.tabPage2.Controls.Add(this.bt_find_KV);
            this.tabPage2.Controls.Add(this.bt_clear_KV);
            this.tabPage2.Controls.Add(this.bt_update_KV);
            this.tabPage2.Controls.Add(this.bt_add_KV);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 64);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 629);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khu Vực";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tb_tenKV
            // 
            this.tb_tenKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_tenKV.Location = new System.Drawing.Point(603, 75);
            this.tb_tenKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tenKV.Name = "tb_tenKV";
            this.tb_tenKV.Size = new System.Drawing.Size(232, 28);
            this.tb_tenKV.TabIndex = 23;
            // 
            // tb_idKV
            // 
            this.tb_idKV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_idKV.Location = new System.Drawing.Point(192, 79);
            this.tb_idKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_idKV.Name = "tb_idKV";
            this.tb_idKV.Size = new System.Drawing.Size(184, 28);
            this.tb_idKV.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(458, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên khu vực:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(28, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã khu vực:";
            // 
            // tb_find_KV
            // 
            this.tb_find_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.tb_find_KV.Location = new System.Drawing.Point(23, 20);
            this.tb_find_KV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_find_KV.Name = "tb_find_KV";
            this.tb_find_KV.Size = new System.Drawing.Size(620, 28);
            this.tb_find_KV.TabIndex = 15;
            // 
            // bt_out_KV
            // 
            this.bt_out_KV.BackColor = System.Drawing.Color.SlateBlue;
            this.bt_out_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_out_KV.ForeColor = System.Drawing.Color.White;
            this.bt_out_KV.Location = new System.Drawing.Point(886, 513);
            this.bt_out_KV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_out_KV.Name = "bt_out_KV";
            this.bt_out_KV.Size = new System.Drawing.Size(175, 47);
            this.bt_out_KV.TabIndex = 16;
            this.bt_out_KV.Text = "Thoát";
            this.bt_out_KV.UseVisualStyleBackColor = false;
            this.bt_out_KV.Click += new System.EventHandler(this.bt_out_KV_Click_1);
            // 
            // bt_find_KV
            // 
            this.bt_find_KV.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_find_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_find_KV.ForeColor = System.Drawing.Color.White;
            this.bt_find_KV.Location = new System.Drawing.Point(660, 10);
            this.bt_find_KV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_find_KV.Name = "bt_find_KV";
            this.bt_find_KV.Size = new System.Drawing.Size(175, 47);
            this.bt_find_KV.TabIndex = 17;
            this.bt_find_KV.Text = "Tìm Kiếm";
            this.bt_find_KV.UseVisualStyleBackColor = false;
            this.bt_find_KV.Click += new System.EventHandler(this.bt_find_KV_Click_1);
            // 
            // bt_clear_KV
            // 
            this.bt_clear_KV.BackColor = System.Drawing.Color.Crimson;
            this.bt_clear_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_clear_KV.ForeColor = System.Drawing.Color.White;
            this.bt_clear_KV.Location = new System.Drawing.Point(886, 396);
            this.bt_clear_KV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_clear_KV.Name = "bt_clear_KV";
            this.bt_clear_KV.Size = new System.Drawing.Size(175, 47);
            this.bt_clear_KV.TabIndex = 18;
            this.bt_clear_KV.Text = "Xóa";
            this.bt_clear_KV.UseVisualStyleBackColor = false;
            this.bt_clear_KV.Click += new System.EventHandler(this.bt_clear_KV_Click_1);
            // 
            // bt_update_KV
            // 
            this.bt_update_KV.BackColor = System.Drawing.Color.ForestGreen;
            this.bt_update_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_update_KV.ForeColor = System.Drawing.Color.White;
            this.bt_update_KV.Location = new System.Drawing.Point(886, 279);
            this.bt_update_KV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_update_KV.Name = "bt_update_KV";
            this.bt_update_KV.Size = new System.Drawing.Size(175, 47);
            this.bt_update_KV.TabIndex = 19;
            this.bt_update_KV.Text = "Cập Nhật";
            this.bt_update_KV.UseVisualStyleBackColor = false;
            this.bt_update_KV.Click += new System.EventHandler(this.bt_update_KV_Click_1);
            // 
            // bt_add_KV
            // 
            this.bt_add_KV.BackColor = System.Drawing.Color.DodgerBlue;
            this.bt_add_KV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.bt_add_KV.ForeColor = System.Drawing.Color.White;
            this.bt_add_KV.Location = new System.Drawing.Point(886, 141);
            this.bt_add_KV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_add_KV.Name = "bt_add_KV";
            this.bt_add_KV.Size = new System.Drawing.Size(175, 47);
            this.bt_add_KV.TabIndex = 20;
            this.bt_add_KV.Text = "Thêm";
            this.bt_add_KV.UseVisualStyleBackColor = false;
            this.bt_add_KV.Click += new System.EventHandler(this.bt_add_KV_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_listKV);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(17, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(835, 443);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Khu Vực";
            // 
            // dgv_listKV
            // 
            this.dgv_listKV.AllowUserToAddRows = false;
            this.dgv_listKV.AllowUserToDeleteRows = false;
            this.dgv_listKV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_listKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listKV.Location = new System.Drawing.Point(17, 54);
            this.dgv_listKV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_listKV.Name = "dgv_listKV";
            this.dgv_listKV.ReadOnly = true;
            this.dgv_listKV.RowHeadersWidth = 51;
            this.dgv_listKV.RowTemplate.Height = 24;
            this.dgv_listKV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listKV.Size = new System.Drawing.Size(801, 385);
            this.dgv_listKV.TabIndex = 0;
            this.dgv_listKV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listKV_CellContentClick);
            this.dgv_listKV.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgv_listKV_RowPrePaint_1);
            // 
            // fBanVaKV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 711);
            this.Controls.Add(this.tabControl1);
            this.Name = "fBanVaKV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn và khu vực";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fBanVaKV_FormClosing);
            this.Load += new System.EventHandler(this.fBanVaKV_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gb_listBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listBan)).EndInit();
            this.gb_Ban.ResumeLayout(false);
            this.gb_Ban.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listKV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_find;
        private System.Windows.Forms.Button bt_out;
        private System.Windows.Forms.Button bt_find;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.GroupBox gb_listBan;
        private System.Windows.Forms.DataGridView dgv_listBan;
        private System.Windows.Forms.GroupBox gb_Ban;
        private System.Windows.Forms.TextBox tb_maKhuVuc;
        private System.Windows.Forms.TextBox tb_tenBan;
        private System.Windows.Forms.TextBox tb_maBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tenKV;
        private System.Windows.Forms.TextBox tb_idKV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_find_KV;
        private System.Windows.Forms.Button bt_out_KV;
        private System.Windows.Forms.Button bt_find_KV;
        private System.Windows.Forms.Button bt_clear_KV;
        private System.Windows.Forms.Button bt_update_KV;
        private System.Windows.Forms.Button bt_add_KV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_listKV;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.ComponentModel.BackgroundWorker backgroundWorker4;
    }
}