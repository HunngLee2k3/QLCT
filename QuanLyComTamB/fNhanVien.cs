using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyComTam
{
    public partial class fNhanVien : Form
    {
        E_Tb_Ca etb;
        E_Tb_Ca ketnoi = new E_Tb_Ca();
        E_Tb_TinhLuong etbluong;
        public fNhanVien()
        {
            InitializeComponent();
            etb = new E_Tb_Ca();
            etbluong = new E_Tb_TinhLuong();
        }
        public void ShowAllTinhLuong()
        {
            DataTable dt = etbluong.GetAllTinhLuong();
            dvg_tinhluong.DataSource = dt;
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void bt_them_Click(object sender, EventArgs e)
        {

        }
        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(tb_maca.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Ca", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_maca.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_makhuvuc.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Khu Vực", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_makhuvuc.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_tenca.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Ca", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_tenca.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_manhanvien.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Nhân Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_manhanvien.Focus();
                return false;
            }
            return true;
        }
        public bool CheckDataLuong()
        {
            if (string.IsNullOrWhiteSpace(tb_manhanvien.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Mã Ca", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_manhanvien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_soca.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Khu Vực", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_soca.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_tongtien.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Tên Ca", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_tongtien.Focus();
                return false;
            }
            return true;
        }
        private void bt_them_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {

                EC_Tb_Ca ca = new EC_Tb_Ca();
                ca.MANHANVIEN = tb_manhanvien.Text;
                ca.TENCA = tb_tenca.Text;
                ca.MACA = tb_maca.Text;
                ca.MAKHUVUC = tb_makhuvuc.Text;
                ca.NGAY = datetime_ngay.Value.ToString();
                if (etb.InsertCa(ca))
                {
                    ShowAllCa();
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Bị Lỗi Không Thêm Được");
                }
            }
        }

        private void bt_sua_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {

                EC_Tb_Ca ca = new EC_Tb_Ca();
                ca.MANHANVIEN = tb_manhanvien.Text;
                ca.TENCA = tb_tenca.Text;
                ca.MACA = tb_maca.Text;
                ca.MAKHUVUC = tb_makhuvuc.Text;
                if (etb.UpdateCa(ca))
                {
                    ShowAllCa();
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Bị Lỗi Khong Sua Được");
                }
            }
        }

        private void bt_xoa_Click_1(object sender, EventArgs e)
        {
            if (CheckData())
            {

                EC_Tb_Ca ca = new EC_Tb_Ca();
                ca.MANHANVIEN = tb_manhanvien.Text;
                ca.TENCA = tb_tenca.Text;
                ca.MACA = tb_maca.Text;
                ca.MAKHUVUC = tb_makhuvuc.Text;
                if (etb.DeleteCa(ca))
                {
                    ShowAllCa();
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Bị Lỗi Khong Xoa Được");
                }
            }
        }
        public void ShowAllCa()
        {
            DataTable dt = etb.GetAllCa();
            dataGridView1.DataSource = dt;
        }
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            ShowAllCa();
            ShowAllTinhLuong();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckDataLuong())
            {

                EC_Tb_TinhLuong tinhluong = new EC_Tb_TinhLuong();
                tinhluong.MANHANVIEN = tb_manhanvien.Text.ToString();
                tinhluong.SOCA = Int32.Parse(tb_soca.Text);
                tinhluong.TONGTIEN = Int32.Parse(tb_tongtien.Text);
                tinhluong.NGAYNHAN = datetime_ngaynhan.Value.ToLongTimeString();
                if (etbluong.InsertTinhLuong(tinhluong))
                {
                    ShowAllTinhLuong();
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Bị Lỗi Không Thêm Được");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckDataLuong())
            {

                EC_Tb_TinhLuong tinhluong = new EC_Tb_TinhLuong();
                tinhluong.MANHANVIEN = tb_manhanvien.Text.ToString();
                tinhluong.SOCA = Int32.Parse(tb_soca.Text);
                tinhluong.TONGTIEN = Int32.Parse(tb_tongtien.Text);
                tinhluong.NGAYNHAN = datetime_ngaynhan.Value.ToLongTimeString();
                if (etbluong.UpdateTinhLuong(tinhluong))
                {
                    ShowAllTinhLuong();
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Bị Lỗi Không Thêm Được");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckDataLuong())
            {

                EC_Tb_TinhLuong tinhluong = new EC_Tb_TinhLuong();
                tinhluong.MANHANVIEN = tb_manhanvien.Text.ToString();
                tinhluong.SOCA = Int32.Parse(tb_soca.Text);
                tinhluong.TONGTIEN = Int32.Parse(tb_tongtien.Text);
                tinhluong.NGAYNHAN = datetime_ngaynhan.Value.ToLongTimeString();
                if (etbluong.DeleteTinhLuong(tinhluong))
                {
                    ShowAllTinhLuong();
                    //dataGridView1.Refresh();
                }
                else
                {
                    MessageBox.Show("Bị Lỗi Không Thêm Được");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
