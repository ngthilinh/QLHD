using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_hop_dong_1
{
    public partial class Form1 : Form
    {
        Ketnoi kn = new Ketnoi();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            kn.KetNoi_Dulieu();
            try
            {
                string TK = txtTen.Text;
                string MK = txtMatKhau.Text;
                string sql_login = "Select UserName, Pass From Taikhoan where UserName= '" + TK + "'and Pass ='" + MK + "'";

                SqlCommand cmd = new SqlCommand(sql_login, kn.cnn);
                SqlDataReader datRed = cmd.ExecuteReader();
                if (datRed.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    // Visible = false;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hãy kiểm tra lại thông tin đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối với Cơ sở dữ liệu!");
            }
        }

        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
