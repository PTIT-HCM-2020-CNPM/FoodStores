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
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumberPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim()!=""&&txtNumberPhone.Text.Trim()!=""&&txtPass.Text.Trim()!=""&&txtRePass.Text.Trim()!="")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtNumberPhone.Text.Trim() != "" && txtPass.Text.Trim() != "" && txtRePass.Text.Trim() != "")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtNumberPhone.Text.Trim() != "" && txtPass.Text.Trim() != "" && txtRePass.Text.Trim() != "")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void txtRePass_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != "" && txtNumberPhone.Text.Trim() != "" && txtPass.Text.Trim() != "" && txtRePass.Text.Trim() != "")
            {
                btnRegis.Enabled = true;
            }
            else { btnRegis.Enabled = false; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
