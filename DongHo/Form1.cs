using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHo
{
    public partial class Form1 : Form
    {
        private int DemNguoc = 60;
        private Timer time;
        private int phut = 0;
        private int giay = 0;
        private Boolean TamDung = false;
        public Form1()
        {
            InitializeComponent();
            time = new Timer();
            time.Interval = 1000;
            time.Tick += time_Tick;
        }

        private void txtPhut_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPhut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '-' && (sender as TextBox).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void txtGiay_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Contains("-"))
            {
                e.Handled = true;
            }
        }

        private void btnChay_Click(object sender, EventArgs e)
        {
            phut = Convert.ToInt32(txtPhut.Text);
            giay = Convert.ToInt32(txtGiay.Text);
            DemNguoc = phut * 60 + giay;
            time.Start();
        }
        private void time_Tick(object sender, EventArgs e)
        {
            DemNguoc--;
            phut = DemNguoc / 60;
            giay = DemNguoc % 60;

            txtPhut.Text = phut.ToString();
            txtGiay.Text = giay.ToString();

            if (DemNguoc == 0)
            {
                time.Stop();
                MessageBox.Show("Đã hết thời gian!");
            }
        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            TamDung = !TamDung;
            if (TamDung)
            {
                time.Stop();
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            txtGiay.Text = "00";
            txtPhut.Text = "00";
            time.Stop();
        }
    }
}
