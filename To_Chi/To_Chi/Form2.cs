using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Chi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                MessageBox.Show("Bạn hãy điền mật khẩu", "Thông báo");
                return;
            }

          

            if (txtMK.Text == "10012003")
            {
                Form1  f1 = new Form1();
                Form2 f2 = new Form2();
                f2.Hide();
                f1.Show();
                txtMK.Text = "";
                return;
            }  
            
            if (!txtMK.Text.All(char.IsDigit))
            {
                MessageBox.Show("Mật khẩu phải là số", "Thông báo");
                txtMK.Text = "";
                txtMK.Focus();
                return;
            }

            if (txtMK.Text != "10012003")
            {
                MessageBox.Show("Sai mật khẩu! Mời bạn nhập lại", "Thông báo");
                txtMK.Text = "";
                txtMK.Focus();
                return;
            }

        }

        private void chkAnHien_CheckedChanged(object sender, EventArgs e)
        {

            txtMK.PasswordChar = chkAnHien.Checked ? '\0' : '*';
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtMK.PasswordChar = '*';
        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && chkAnHien.Checked != chkAnHien.Checked)
            {
                chkAnHien.Checked = !chkAnHien.Checked;  
            }
        }
    }
}
