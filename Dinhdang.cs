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
    public partial class Dinhdang : Form
    {
        public Dinhdang()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Green;
            txtnhapten.ForeColor = Color.Green;
            txtlaptrinhboi.ForeColor = Color.Green;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnhapten_TextChanged(object sender, EventArgs e)
        {
            txtlaptrinhboi.Text = txtnhapten.Text;
            lbllaptrinh.Text = txtnhapten.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Red;
            txtnhapten.ForeColor = Color.Red;
            txtlaptrinhboi.ForeColor = Color.Red;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Blue;
            txtnhapten.ForeColor = Color.Blue;
            txtlaptrinhboi.ForeColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            lbllaptrinh.ForeColor = Color.Black;
            txtnhapten.ForeColor = Color.Black;
            txtlaptrinhboi.ForeColor = Color.Black;
        }

        private void chkdambold_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinhboi.Font = new Font(lbllaptrinh.Font.Name, txtlaptrinhboi.Font.Size,txtlaptrinhboi.Font.Style ^ FontStyle.Bold);
            lbllaptrinh.Font = new Font(txtlaptrinhboi.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chknghiengitalic_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinhboi.Font = new Font(lbllaptrinh.Font.Name, txtlaptrinhboi.Font.Size, txtlaptrinhboi.Font.Style ^ FontStyle.Italic);
            lbllaptrinh.Font = new Font(txtlaptrinhboi.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkgachchan_CheckedChanged(object sender, EventArgs e)
        {
            txtlaptrinhboi.Font = new Font(lbllaptrinh.Font.Name, txtlaptrinhboi.Font.Size, txtlaptrinhboi.Font.Style ^ FontStyle.Underline);
            lbllaptrinh.Font = new Font(txtlaptrinhboi.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Underline);
        }

        private void Dinhdang_Load(object sender, EventArgs e)
        {

        }
    }
}
