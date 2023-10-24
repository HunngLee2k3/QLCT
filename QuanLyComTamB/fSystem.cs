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
    public partial class fSystem : Form
    {
        public fSystem()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fTable qLBH = new fTable();
            this.Hide();
            qLBH.ShowDialog();
            this.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            DoanhThu baoCao = new DoanhThu();
            this.Hide();
            baoCao.ShowDialog();
            this.Show();
        }

        private void btnBan_KV_Click(object sender, EventArgs e)
        {
            fBanVaKV fBanVaKV = new fBanVaKV();
            this.Hide();
            fBanVaKV.ShowDialog();
            this.Show();
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            QLMenu qLMenu = new QLMenu();
            this.Hide();
            qLMenu.ShowDialog();
            this.Show();
        }

        private void btnThoatSYS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVien fnv = new fNhanVien();
            this.Hide();
            fnv.ShowDialog();
            this.Show();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            fAccount facn = new fAccount();
            this.Hide();
            facn.ShowDialog();
            this.Show();
        }
    }
}
