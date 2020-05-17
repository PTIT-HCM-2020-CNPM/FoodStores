using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFood
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim()!=""&&txtPass.Text.Trim()!="")
            {
                btnLogin.Enabled = true;
            }
            else { btnLogin.Enabled = false; }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if(txtUser.Text.Trim() != "" && txtPass.Text.Trim() != "")
            {
                btnLogin.Enabled = true;
            }
            else { btnLogin.Enabled = false; }
        }
    }
}
