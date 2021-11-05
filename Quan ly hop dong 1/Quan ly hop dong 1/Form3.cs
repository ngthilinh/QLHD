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
    public partial class Form3 : Form
    {
        Ketnoi ketnoi = new Ketnoi();
        public Form3()
        {
            InitializeComponent();
        }
        public void Load_dulieu_hopdong()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.Lay_Dulieu("Select MaHD,TenHD,NoiDung,NgBatDau,NgKetThuc,MaKH,MaQL From HD");
            dgvHopDong.DataSource = dta;
            Hienthi_Dulieu();
        }

        private void Hienthi_Dulieu()
        {
            txtMaHD.DataBindings.Clear();
            txtMaHD.DataBindings.Add("Text", dgvHopDong.DataSource, "MaHD");

            txtTenHD.DataBindings.Clear();
            txtTenHD.DataBindings.Add("Text", dgvHopDong.DataSource, "TenHD");


        }
        private void Form3_Load(object sender, EventArgs e) //Để tải dữ liệu của bảng lên 
        {
            Load_dulieu_hopdong();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
