using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoTanThanh_01_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giảiPhươngTrìnhBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            String hovaten = "Hồ Tấn Thành";
            String mssv = "123456789";
            String monthi = "Lập trình Window2 - C#";

            lblInfo.Text = "Họ Và Tên: " + hovaten;
            lblInfo.Text += "\nMSSV: " + mssv;
            lblInfo.Text += "\nNgày thi: " + System.DateTime.Now.ToString();
            lblInfo.Text += "\nMôn thi: " + monthi;
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinhdang gpt = new Dinhdang();
            gpt.Show();
        }
    }
}
