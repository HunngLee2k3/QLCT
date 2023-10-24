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
    public partial class fBanVaKV : Form
    {
        public fBanVaKV()
        {
            InitializeComponent();
        }
        SqlConnection connection;
        private void gb_Ban_Enter(object sender, EventArgs e)
        {

        }

        private void bt_out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void load_dataKV()
        {
            string sqlSelect = "select *, '' from KHUVUC";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listKV.DataSource = table;
            dgv_listKV.Columns[0].HeaderText = "Mã khu vực";
            dgv_listKV.Columns[1].HeaderText = "Tên khu vực";
            dgv_listKV.Columns[2].HeaderText = "Ghi chú";
            dgv_listKV.Columns[0].Width = 200;
            dgv_listKV.Columns[1].Width = 200;
            dgv_listKV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void bt_find_Click(object sender, EventArgs e)
        {
            string strFind = "select MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc), '' from BAN where MaBan LIKE @TuKhoa OR TenBan LIKE @TuKhoa OR MaKhuVuc LIKE @TuKhoa";
            SqlCommand cmdFind = new SqlCommand(strFind, connection);
            cmdFind.Parameters.AddWithValue("TuKhoa", "%" + tb_find.Text + "%");
            SqlDataReader reader = cmdFind.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listBan.DataSource = table;
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            string sqlClear = "delete from BAN where @MaBan= MaBan";
            SqlCommand cmd = new SqlCommand(sqlClear, connection);
            cmd.Parameters.AddWithValue("@MaBan", tb_maBan.Text);
            cmd.Parameters.AddWithValue("@TenBan", tb_tenBan.Text);
            cmd.Parameters.AddWithValue("@MaKhuVuc", tb_maKhuVuc.Text);
            cmd.ExecuteNonQuery();
            load_data();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "update BAN set TenBan = @TenBan, MaKhuVuc = @MaKhuVuc where MaBan = @MaBan";
            SqlCommand cmd = new SqlCommand(sqlUpdate, connection);

            cmd.Parameters.AddWithValue("@MaBan", tb_maBan.Text);
            cmd.Parameters.AddWithValue("@TenBan", tb_tenBan.Text);
            cmd.Parameters.AddWithValue("@MaKhuVuc", tb_maKhuVuc.Text);
            cmd.ExecuteNonQuery();
            load_data();
        }
        void load_data()
        {
            string sqlSelect = "select MaBan, TenBan, MaKhuVuc, TenKhuVuc = (SELECT TenKhuVuc FROM KHUVUC WHERE KHUVUC.MaKhuVuc = BAN.MaKhuVuc), '' from BAN";
            SqlCommand command = new SqlCommand(sqlSelect, connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();

            table.Load(reader);

            dgv_listBan.DataSource = table;
            dgv_listBan.Columns[0].HeaderText = "Mã bàn";
            dgv_listBan.Columns[1].HeaderText = "Tên bàn";
            dgv_listBan.Columns[2].HeaderText = "Mã khu vực";
            dgv_listBan.Columns[3].HeaderText = "Tên khu vực";
            dgv_listBan.Columns[4].HeaderText = "Ghi chú";
            dgv_listBan.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void bt_add_Click(object sender, EventArgs e)
        {

            string sqlADD = "insert into BAN values (@MaBan, @TenBan, @MaKhuVuc)";
            SqlCommand cmd = new SqlCommand(sqlADD, connection);
            cmd.Parameters.AddWithValue("@MaBan", tb_maBan.Text);
            cmd.Parameters.AddWithValue("@TenBan", tb_tenBan.Text);
            cmd.Parameters.AddWithValue("@MaKhuVuc", tb_maKhuVuc.Text);
            cmd.ExecuteNonQuery();
            load_data();
        }
        private void dgv_listBan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = dgv_listBan.CurrentRow.Index;
            tb_maBan.Text = dgv_listBan.Rows[i].Cells[0].Value.ToString();
            tb_tenBan.Text = dgv_listBan.Rows[i].Cells[1].Value.ToString();
            tb_maKhuVuc.Text = dgv_listBan.Rows[i].Cells[2].Value.ToString();

        }
        private void gb_listBan_Enter(object sender, EventArgs e)
        {

        }

        private void tb_find_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_find_KV_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_out_KV_Click(object sender, EventArgs e)
        {

        }

        private void bt_find_KV_Click(object sender, EventArgs e)
        {

        }

        private void bt_clear_KV_Click(object sender, EventArgs e)
        {

        }

        private void bt_update_KV_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_KV_Click(object sender, EventArgs e)
        {

        }

        private void dgv_listKV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = dgv_listBan.CurrentRow.Index;
            tb_maBan.Text = dgv_listBan.Rows[i].Cells[0].Value.ToString();
            tb_tenBan.Text = dgv_listBan.Rows[i].Cells[1].Value.ToString();
            tb_maKhuVuc.Text = dgv_listBan.Rows[i].Cells[2].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bt_clear_KV_Click_1(object sender, EventArgs e)
        {
            string sqlClear = "delete from KHUVUC where @MaKhuVuc = MaKhuVuc";
            SqlCommand cmd = new SqlCommand(sqlClear, connection);
            cmd.Parameters.AddWithValue("@MaKhuVuc", tb_idKV.Text);
            cmd.Parameters.AddWithValue("@TenKhuVuc", tb_tenKV.Text);
            cmd.ExecuteNonQuery();
            load_dataKV();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        
        private void tb_maKhuVuc_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void fBanVaKV_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(DB.ConnectString);
            connection.Open();
            load_data();
            load_dataKV();
            
        }

        private void bt_find_KV_Click_1(object sender, EventArgs e)
        {
            string strFind = "select *, '' from KHUVUC where MaKhuVuc = @MaKhuVuc";
            SqlCommand command = new SqlCommand(strFind, connection);

            command.Parameters.AddWithValue("MaKhuVuc", tb_find_KV.Text);
            command.Parameters.AddWithValue("TenKhuVuc", tb_tenKV.Text);

            command.ExecuteNonQuery();

            SqlDataReader reader = command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dgv_listKV.DataSource = table;
        }

        private void bt_add_KV_Click_1(object sender, EventArgs e)
        {
            string sqlADD = "insert into KHUVUC values (@MaKhuVuc, @TenKhuVuc)";
            SqlCommand cmd = new SqlCommand(sqlADD, connection);
            cmd.Parameters.AddWithValue("@MaKhuVuc", tb_idKV.Text);
            cmd.Parameters.AddWithValue("@TenKhuVuc", tb_tenKV.Text);

            cmd.ExecuteNonQuery();
            load_dataKV();
        }

        private void bt_update_KV_Click_1(object sender, EventArgs e)
        {
            string sqlupdate = "update KHUVUC set TenKhuVuc = @TenKhuVuc where MaKhuVuc = @MaKhuVuc";
            SqlCommand cmd = new SqlCommand(sqlupdate, connection);
            cmd.Parameters.AddWithValue("@MaKhuVuc", tb_idKV.Text);
            cmd.Parameters.AddWithValue("@TenKhuVuc", tb_tenKV.Text);
            cmd.ExecuteNonQuery();
            load_dataKV();
        }

        private void bt_out_KV_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_listKV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fBanVaKV_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void dgv_listBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_listKV_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int i = 0;
            i = dgv_listKV.CurrentRow.Index;
            tb_idKV.Text = dgv_listKV.Rows[i].Cells[0].Value.ToString();
            tb_tenKV.Text = dgv_listKV.Rows[i].Cells[1].Value.ToString();
        }
    }
}
