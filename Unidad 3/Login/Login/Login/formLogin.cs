using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtPass.Text == "admin")
            {
                MessageBox.Show("Bienvedio al sistema", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o Contrasela icorrecta", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);              
            }
        }

        private void lnkOlvidaPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usted es un usuario muy descuidado, haga memoria", "Olvide mi contraseña", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtPass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
