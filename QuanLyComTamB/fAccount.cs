using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyComTam
{
    public partial class fAccount : Form
    {
        
        public fAccount()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        void load_data_NV()
        {
            string sqlSelect = "select * from NHANVIEN";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listNV.DataSource = table;
        }
        void load_data_KH()
        {
            string sqlSelect = "select * from KHACHHANG";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_list_KH.DataSource = table;
        }
        private void tb_matNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_find_NV_Click(object sender, EventArgs e)
        {
            string strFind = "select * from NHANVIEN where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(strFind, connection);
            cmd.Parameters.AddWithValue("MaNV", tb_find_NV.Text);
            cmd.Parameters.AddWithValue("TenNV", tb_tenNV.Text);
            cmd.Parameters.AddWithValue("DiaChi", tb_dcNV.Text);
            cmd.Parameters.AddWithValue("SDT", tb_tenNV.Text);
            cmd.Parameters.AddWithValue("Email", tb_mail_NV.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", tb_loginNV.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tb_passNV.Text);
            cmd.Parameters.AddWithValue("@MaQuyen", tb_MQNV.Text);

            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listNV.DataSource = table;
        }

        private void bt_add_NV_Click(object sender, EventArgs e)
        {
            string sqlADD = "insert into NHANVIEN values (@MaNV, @TenNV, @DiaChi, @SDT, @Email, @TenDangNhap, @MatKhau, @MaQuyen)";
            SqlCommand cmdADD = new SqlCommand(sqlADD, connection);
            cmdADD.Parameters.AddWithValue("@MaNV", tb_matNV.Text);
            cmdADD.Parameters.AddWithValue("@TenNV", tb_tenNV.Text);
            cmdADD.Parameters.AddWithValue("@DiaChi", tb_dcNV.Text);
            cmdADD.Parameters.AddWithValue("@SDT", tb_sdtNV.Text);
            cmdADD.Parameters.AddWithValue("@Email", tb_mail_NV.Text);
            cmdADD.Parameters.AddWithValue("@TenDangNhap", tb_loginNV.Text);
            cmdADD.Parameters.AddWithValue("@MatKhau", tb_passNV.Text);
            cmdADD.Parameters.AddWithValue("@MaQuyen", tb_MQNV.Text);
            cmdADD.ExecuteNonQuery();
            load_data_NV();
        }

        private void bt_update_NV_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "update NHANVIEN set TenNV = @TenNV, DiaChi=@DiaChi, SDT=@SDT,Email= @Email, TenDangNhap=@TenDangNhap, MatKhau=@MatKhau, MaQuyen= @MaQuyen where MaNV = @MaNV";
            SqlCommand cmd = new SqlCommand(sqlUpdate, connection);
            cmd.Parameters.AddWithValue("@MaNV", tb_matNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", tb_tenNV.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tb_dcNV.Text);
            cmd.Parameters.AddWithValue("@SDT", tb_sdtNV.Text);
            cmd.Parameters.AddWithValue("@Email", tb_mail_NV.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", tb_loginNV.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tb_passNV.Text);
            cmd.Parameters.AddWithValue("@MaQuyen", tb_MQNV.Text);
            cmd.ExecuteNonQuery();
            load_data_NV();
        }

        private void bt_clear_NV_Click(object sender, EventArgs e)
        {
            string sqlClear = "delete from NHANVIEN where @MaNV = MaNV";
            SqlCommand cmd = new SqlCommand(sqlClear, connection);
            cmd.Parameters.AddWithValue("@MaNV", tb_matNV.Text);
            cmd.Parameters.AddWithValue("@TenNV", tb_tenNV.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tb_dcNV.Text);
            cmd.Parameters.AddWithValue("@SDT", tb_sdtNV.Text);
            cmd.Parameters.AddWithValue("@Email", tb_mail_NV.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", tb_loginNV.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tb_passNV.Text);
            cmd.Parameters.AddWithValue("@MaQuyen", tb_MQNV.Text);
            cmd.ExecuteNonQuery();
            load_data_NV();
        }

        private void bt_out_NV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data_NV();
            load_data_KH();
        }

        private void fAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void tb_maKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_find_KH_Click(object sender, EventArgs e)
        {
            string strFind = "select * from KHACHHANG where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(strFind, connection);

            cmd.Parameters.AddWithValue("MaKH", tb_find_KH.Text);
            cmd.Parameters.AddWithValue("TenKH", tb_tenKH.Text);
            cmd.Parameters.AddWithValue("DiaChi", tb_dc_KH.Text);
            cmd.Parameters.AddWithValue("SDT", tb_sdt_KH.Text);
            cmd.Parameters.AddWithValue("Email", tb_email_KH.Text);
            cmd.Parameters.AddWithValue("MaLKH", tb_loai_KH.Text);
            cmd.Parameters.AddWithValue("@MaQuyen", tb_MQKH.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", tb_loginKH.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tb_passKH.Text);

            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_list_KH.DataSource = table;

        }

        private void bt_add_KH_Click(object sender, EventArgs e)
        {
            string sqlADD = "insert into KHACHHANG values (@MaKH, @TenKH, @DiaChi, @SDT, @Email, @MaLKH, @MaQuyen, @TenDangNhap, @MatKhau)";
            SqlCommand cmdADD = new SqlCommand(sqlADD, connection);
            cmdADD.Parameters.AddWithValue("@MaKH", tb_maKH.Text);
            cmdADD.Parameters.AddWithValue("@TenKH", tb_tenKH.Text);
            cmdADD.Parameters.AddWithValue("@DiaChi", tb_dc_KH.Text);
            cmdADD.Parameters.AddWithValue("@SDT", tb_sdt_KH.Text);
            cmdADD.Parameters.AddWithValue("@Email", tb_email_KH.Text);
            cmdADD.Parameters.AddWithValue("@MaLKH", tb_loai_KH.Text);
            cmdADD.Parameters.AddWithValue("@MaQuyen", tb_MQKH.Text);
            cmdADD.Parameters.AddWithValue("@TenDangNhap", tb_loginKH.Text);
            cmdADD.Parameters.AddWithValue("@MatKhau", tb_passKH.Text);
            cmdADD.ExecuteNonQuery();
            load_data_KH();
        }

        private void bt_update_KH_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "update KHACHHANG set TenKH = @TenKH, DiaChi=@DiaChi, SDT=@SDT,Email= @Email, MaLKH=@MaLKH, MaQuyen=@MaQuyen,TenDangNhap= @TenDangNhap,MatKhau =  @MatKhau where MaKH = @MaKH";
            SqlCommand cmd = new SqlCommand(sqlUpdate, connection);
            cmd.Parameters.AddWithValue("@MaKH", tb_maKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", tb_tenKH.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tb_dc_KH.Text);
            cmd.Parameters.AddWithValue("@SDT", tb_sdt_KH.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email_KH.Text);
            cmd.Parameters.AddWithValue("@MaLKH", tb_loai_KH.Text);
            cmd.Parameters.AddWithValue("@MaQuyen", tb_MQKH.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", tb_loginKH.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tb_passKH.Text);

            cmd.ExecuteNonQuery();
            load_data_KH();
        }

        private void bt_clear_KH_Click(object sender, EventArgs e)
        {
            string sqlClear = "delete from KHACHHANG where @MaKH = MaKH";
            SqlCommand cmd = new SqlCommand(sqlClear, connection);
            cmd.Parameters.AddWithValue("@MaKH", tb_maKH.Text);
            cmd.Parameters.AddWithValue("@TenKH", tb_tenKH.Text);
            cmd.Parameters.AddWithValue("@DiaChi", tb_dc_KH.Text);
            cmd.Parameters.AddWithValue("@SDT", tb_sdt_KH.Text);
            cmd.Parameters.AddWithValue("@Email", tb_email_KH.Text);
            cmd.Parameters.AddWithValue("@MaLKH", tb_loai_KH.Text);
            cmd.Parameters.AddWithValue("@MaQuyen", tb_MQKH.Text);
            cmd.Parameters.AddWithValue("@TenDangNhap", tb_loginKH.Text);
            cmd.Parameters.AddWithValue("@MatKhau", tb_passKH.Text);
            cmd.ExecuteNonQuery();
            load_data_KH();
        }

        private void bt_out_KH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_listNV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = 0;
            i = dgv_listNV.CurrentRow.Index;
            tb_matNV.Text = dgv_listNV.Rows[i].Cells[0].Value.ToString();
            tb_tenNV.Text = dgv_listNV.Rows[i].Cells[1].Value.ToString();
            tb_dcNV.Text = dgv_listNV.Rows[i].Cells[2].Value.ToString();
            tb_sdtNV.Text = dgv_listNV.Rows[i].Cells[3].Value.ToString();
            tb_mail_NV.Text = dgv_listNV.Rows[i].Cells[4].Value.ToString();
            tb_loginNV.Text = dgv_listNV.Rows[i].Cells[5].Value.ToString();
            tb_passNV.Text = dgv_listNV.Rows[i].Cells[6].Value.ToString();
            tb_MQNV.Text = dgv_listNV.Rows[i].Cells[7].Value.ToString();
        }

        private void dgv_list_KH_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = 0;
            i = dgv_list_KH.CurrentRow.Index;
            tb_maKH.Text = dgv_list_KH.Rows[i].Cells[0].Value.ToString();
            tb_tenKH.Text = dgv_list_KH.Rows[i].Cells[1].Value.ToString();
            tb_dc_KH.Text = dgv_list_KH.Rows[i].Cells[2].Value.ToString();
            tb_sdt_KH.Text = dgv_list_KH.Rows[i].Cells[3].Value.ToString();
            tb_email_KH.Text = dgv_list_KH.Rows[i].Cells[4].Value.ToString();
            tb_loai_KH.Text = dgv_list_KH.Rows[i].Cells[5].Value.ToString();
            tb_MQKH.Text = dgv_list_KH.Rows[i].Cells[6].Value.ToString();
            tb_loginKH.Text = dgv_list_KH.Rows[i].Cells[7].Value.ToString();
            tb_passKH.Text = dgv_list_KH.Rows[i].Cells[8].Value.ToString();
        }
    }
}
