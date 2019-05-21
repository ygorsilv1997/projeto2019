using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace index
{
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
        }

        private void chkPass_CheckedChanged(object sender, EventArgs e)
        {
            
            if(chkPass.Checked)
            {
                txtPass.PasswordChar = '\u0000';
            }
            else
            {
                txtPass.PasswordChar = '*';
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string checar;
            DAO.login validar = new DAO.login();
            checar=validar.loginUser(txtUser.Text,txtPass.Text);

            if (checar.Length > 0 )
            {
                MessageBox.Show(checar);

                this.Hide();
                Form menu = new menu.homeUser();
                menu.ShowDialog();
                
            }
            else
            {
                MessageBox.Show(checar);
            }
      


        }
    }
}
