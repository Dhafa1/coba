using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

            if (tb_nama.Text.Length == 0 || tb_nis.Text.Length == 0)
            {

                DialogResult result = MessageBox.Show("Ada form yang belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string namaBulan = dtp_tgllahir.Value.ToString("MMMM");
                lbl_informasi.Visible = true;
                lbl_informasi.Text = "Hello " + tb_nama.Text + Environment.NewLine + 
                     tb_nis.Text + Environment.NewLine + 
                     dtp_tgllahir.Value.ToString("dd") + "-" + namaBulan + "-" + dtp_tgllahir.Value.ToString("yyyy");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp_tgllahir.Format = DateTimePickerFormat.Custom;
            dtp_tgllahir.CustomFormat = "dddd, dd/MM/yyyy";
        }
    }
}
